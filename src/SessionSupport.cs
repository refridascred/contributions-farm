using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Queued,
            Draft,
        }
    }
}
