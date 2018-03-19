// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Azure event log entries are of type EventData
    /// </summary>
    public partial class EventDataInner
    {
        /// <summary>
        /// Initializes a new instance of the EventDataInner class.
        /// </summary>
        public EventDataInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventDataInner class.
        /// </summary>
        /// <param name="claims">key value pairs to identify ARM
        /// permissions.</param>
        /// <param name="caller">the email address of the user who has
        /// performed the operation, the UPN claim or SPN claim based on
        /// availability.</param>
        /// <param name="description">the description of the event.</param>
        /// <param name="id">the Id of this event as required by ARM for RBAC.
        /// It contains the EventDataID and a timestamp information.</param>
        /// <param name="eventDataId">the event data Id. This is a unique
        /// identifier for an event.</param>
        /// <param name="correlationId">the correlation Id, usually a GUID in
        /// the string format. The correlation Id is shared among the events
        /// that belong to the same uber operation.</param>
        /// <param name="eventName">the event name. This value should not be
        /// confused with OperationName. For practical purposes, OperationName
        /// might be more appealing to end users.</param>
        /// <param name="category">the event category.</param>
        /// <param name="httpRequest">the HTTP request info. Usually includes
        /// the 'clientRequestId', 'clientIpAddress' (IP address of the user
        /// who initiated the event) and 'method' (HTTP method e.g.
        /// PUT).</param>
        /// <param name="level">the event level. Possible values include:
        /// 'Critical', 'Error', 'Warning', 'Informational', 'Verbose'</param>
        /// <param name="resourceGroupName">the resource group name of the
        /// impacted resource.</param>
        /// <param name="resourceProviderName">the resource provider name of
        /// the impacted resource.</param>
        /// <param name="resourceId">the resource uri that uniquely identifies
        /// the resource that caused this event.</param>
        /// <param name="resourceType">the resource type</param>
        /// <param name="operationId">It is usually a GUID shared among the
        /// events corresponding to single operation. This value should not be
        /// confused with EventName.</param>
        /// <param name="operationName">the operation name.</param>
        /// <param name="properties">the set of &lt;Key, Value&gt; pairs
        /// (usually a Dictionary&lt;String, String&gt;) that includes details
        /// about the event.</param>
        /// <param name="status">a string describing the status of the
        /// operation. Some typical values are: Started, In progress,
        /// Succeeded, Failed, Resolved.</param>
        /// <param name="subStatus">the event sub status. Most of the time,
        /// when included, this captures the HTTP status code of the REST call.
        /// Common values are: OK (HTTP Status Code: 200), Created (HTTP Status
        /// Code: 201), Accepted (HTTP Status Code: 202), No Content (HTTP
        /// Status Code: 204), Bad Request(HTTP Status Code: 400), Not Found
        /// (HTTP Status Code: 404), Conflict (HTTP Status Code: 409), Internal
        /// Server Error (HTTP Status Code: 500), Service Unavailable (HTTP
        /// Status Code:503), Gateway Timeout (HTTP Status Code: 504)</param>
        /// <param name="eventTimestamp">the timestamp of when the event was
        /// generated by the Azure service processing the request corresponding
        /// the event. It in ISO 8601 format.</param>
        /// <param name="submissionTimestamp">the timestamp of when the event
        /// became available for querying via this API. It is in ISO 8601
        /// format. This value should not be confused eventTimestamp. As there
        /// might be a delay between the occurrence time of the event, and the
        /// time that the event is submitted to the Azure logging
        /// infrastructure.</param>
        /// <param name="subscriptionId">the Azure subscription Id usually a
        /// GUID.</param>
        /// <param name="tenantId">the Azure tenant Id</param>
        public EventDataInner(SenderAuthorization authorization = default(SenderAuthorization), IDictionary<string, string> claims = default(IDictionary<string, string>), string caller = default(string), string description = default(string), string id = default(string), string eventDataId = default(string), string correlationId = default(string), LocalizableString eventName = default(LocalizableString), LocalizableString category = default(LocalizableString), HttpRequestInfo httpRequest = default(HttpRequestInfo), EventLevel? level = default(EventLevel?), string resourceGroupName = default(string), LocalizableString resourceProviderName = default(LocalizableString), string resourceId = default(string), LocalizableString resourceType = default(LocalizableString), string operationId = default(string), LocalizableString operationName = default(LocalizableString), IDictionary<string, string> properties = default(IDictionary<string, string>), LocalizableString status = default(LocalizableString), LocalizableString subStatus = default(LocalizableString), System.DateTime? eventTimestamp = default(System.DateTime?), System.DateTime? submissionTimestamp = default(System.DateTime?), string subscriptionId = default(string), string tenantId = default(string))
        {
            Authorization = authorization;
            Claims = claims;
            Caller = caller;
            Description = description;
            Id = id;
            EventDataId = eventDataId;
            CorrelationId = correlationId;
            EventName = eventName;
            Category = category;
            HttpRequest = httpRequest;
            Level = level;
            ResourceGroupName = resourceGroupName;
            ResourceProviderName = resourceProviderName;
            ResourceId = resourceId;
            ResourceType = resourceType;
            OperationId = operationId;
            OperationName = operationName;
            Properties = properties;
            Status = status;
            SubStatus = subStatus;
            EventTimestamp = eventTimestamp;
            SubmissionTimestamp = submissionTimestamp;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authorization")]
        public SenderAuthorization Authorization { get; private set; }

        /// <summary>
        /// Gets key value pairs to identify ARM permissions.
        /// </summary>
        [JsonProperty(PropertyName = "claims")]
        public IDictionary<string, string> Claims { get; private set; }

        /// <summary>
        /// Gets the email address of the user who has performed the operation,
        /// the UPN claim or SPN claim based on availability.
        /// </summary>
        [JsonProperty(PropertyName = "caller")]
        public string Caller { get; private set; }

        /// <summary>
        /// Gets the description of the event.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the Id of this event as required by ARM for RBAC. It contains
        /// the EventDataID and a timestamp information.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the event data Id. This is a unique identifier for an event.
        /// </summary>
        [JsonProperty(PropertyName = "eventDataId")]
        public string EventDataId { get; private set; }

        /// <summary>
        /// Gets the correlation Id, usually a GUID in the string format. The
        /// correlation Id is shared among the events that belong to the same
        /// uber operation.
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; private set; }

        /// <summary>
        /// Gets the event name. This value should not be confused with
        /// OperationName. For practical purposes, OperationName might be more
        /// appealing to end users.
        /// </summary>
        [JsonProperty(PropertyName = "eventName")]
        public LocalizableString EventName { get; private set; }

        /// <summary>
        /// Gets the event category.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public LocalizableString Category { get; private set; }

        /// <summary>
        /// Gets the HTTP request info. Usually includes the 'clientRequestId',
        /// 'clientIpAddress' (IP address of the user who initiated the event)
        /// and 'method' (HTTP method e.g. PUT).
        /// </summary>
        [JsonProperty(PropertyName = "httpRequest")]
        public HttpRequestInfo HttpRequest { get; private set; }

        /// <summary>
        /// Gets the event level. Possible values include: 'Critical', 'Error',
        /// 'Warning', 'Informational', 'Verbose'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public EventLevel? Level { get; private set; }

        /// <summary>
        /// Gets the resource group name of the impacted resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; private set; }

        /// <summary>
        /// Gets the resource provider name of the impacted resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceProviderName")]
        public LocalizableString ResourceProviderName { get; private set; }

        /// <summary>
        /// Gets the resource uri that uniquely identifies the resource that
        /// caused this event.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; private set; }

        /// <summary>
        /// Gets the resource type
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public LocalizableString ResourceType { get; private set; }

        /// <summary>
        /// Gets it is usually a GUID shared among the events corresponding to
        /// single operation. This value should not be confused with EventName.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; private set; }

        /// <summary>
        /// Gets the operation name.
        /// </summary>
        [JsonProperty(PropertyName = "operationName")]
        public LocalizableString OperationName { get; private set; }

        /// <summary>
        /// Gets the set of &amp;lt;Key, Value&amp;gt; pairs (usually a
        /// Dictionary&amp;lt;String, String&amp;gt;) that includes details
        /// about the event.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// Gets a string describing the status of the operation. Some typical
        /// values are: Started, In progress, Succeeded, Failed, Resolved.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public LocalizableString Status { get; private set; }

        /// <summary>
        /// Gets the event sub status. Most of the time, when included, this
        /// captures the HTTP status code of the REST call. Common values are:
        /// OK (HTTP Status Code: 200), Created (HTTP Status Code: 201),
        /// Accepted (HTTP Status Code: 202), No Content (HTTP Status Code:
        /// 204), Bad Request(HTTP Status Code: 400), Not Found (HTTP Status
        /// Code: 404), Conflict (HTTP Status Code: 409), Internal Server Error
        /// (HTTP Status Code: 500), Service Unavailable (HTTP Status
        /// Code:503), Gateway Timeout (HTTP Status Code: 504)
        /// </summary>
        [JsonProperty(PropertyName = "subStatus")]
        public LocalizableString SubStatus { get; private set; }

        /// <summary>
        /// Gets the timestamp of when the event was generated by the Azure
        /// service processing the request corresponding the event. It in ISO
        /// 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "eventTimestamp")]
        public System.DateTime? EventTimestamp { get; private set; }

        /// <summary>
        /// Gets the timestamp of when the event became available for querying
        /// via this API. It is in ISO 8601 format. This value should not be
        /// confused eventTimestamp. As there might be a delay between the
        /// occurrence time of the event, and the time that the event is
        /// submitted to the Azure logging infrastructure.
        /// </summary>
        [JsonProperty(PropertyName = "submissionTimestamp")]
        public System.DateTime? SubmissionTimestamp { get; private set; }

        /// <summary>
        /// Gets the Azure subscription Id usually a GUID.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets the Azure tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EventName != null)
            {
                EventName.Validate();
            }
            if (Category != null)
            {
                Category.Validate();
            }
            if (ResourceProviderName != null)
            {
                ResourceProviderName.Validate();
            }
            if (ResourceType != null)
            {
                ResourceType.Validate();
            }
            if (OperationName != null)
            {
                OperationName.Validate();
            }
            if (Status != null)
            {
                Status.Validate();
            }
            if (SubStatus != null)
            {
                SubStatus.Validate();
            }
        }
    }
}
