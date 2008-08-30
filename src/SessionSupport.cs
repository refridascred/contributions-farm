using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Closed,
            Idle,
            New,
        }
    }
}
