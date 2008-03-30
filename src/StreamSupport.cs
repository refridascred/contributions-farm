using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleScore = 4486;
        public const double WindowRecord = 80.67;
        public const double SoftRecord = 96.08;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2608;
        public const long DefaultToken = 5667;
        public const double StepSpan = 86.37;
    }
}
