using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 7685;
        public const long DefaultDepth = 3808;
        public const double BatchTools = 82.88;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            New,
            Failed,
            Done,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftRatio = 862;
        public const long WindowRatio = 3514;
        public const double DefaultSpan = 18.73;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Ready,
            Active,
            Locked,
        }
    }
}
