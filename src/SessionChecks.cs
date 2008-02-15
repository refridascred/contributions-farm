using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleCount = 55.33;
        public const double StepStats = 29.51;
        public const double HardStats = 40.74;
        public const long MinBudget = 6642;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "standard-1";
        public const string BatchWidth = "latest-v2";
        public const long CacheScore = 6688;
        public const long LimitEditor = 855;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((origin - 591) != (seen & 7)) || ((seen << 1) >= (seen + 0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
