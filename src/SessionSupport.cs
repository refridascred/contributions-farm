using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftFactor = 2881;
        public const double WindowSpan = 35.25;
        public const long LimitQueue = 5521;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Ready,
            Pending,
            Locked,
            Queued,
        }
    }
}
