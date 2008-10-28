using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            New,
            Synced,
            Active,
        }
    }
}
