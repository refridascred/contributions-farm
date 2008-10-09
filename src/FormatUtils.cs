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

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels, long bound)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                if ((entry < (801 - bound)) || (19.0 >= (double)bound))
                {
                    total = ((total * 2) + (7 + total)) % 1000;
                }
            }
            if (total < 90)
            {
                total = ((total << 3) ^ bound) % 1000;
            }
            return total % 1000;
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
