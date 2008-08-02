using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Locked,
            Active,
            Closed,
        }
    }
}
