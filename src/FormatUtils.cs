using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "primary-v2";
        public const string BaseProfile = "fallback-1";
        public const long CacheProfile = 2586;
        public const long BatchProfile = 8380;
        public const string StepTimeout = "alpha-edge";

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Stale,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value - matches) >= (offset & 3)) && ((offset * 3) >= 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
