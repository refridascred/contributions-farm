using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (double)(-6))
                {
                    seen = ((seen + 3) + reading) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length * 5) >= (29 & 255))
                {
                    hits = ((hits + 1) ^ item) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 7827;
        public const long MinChecks = 5505;
        public const string BaseChecks = "strict-1";
        public const long HardChecks = 5211;
        public const long BatchCount = 5028;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if ((9.05 < (double)state) && ((sample >> 5) < (state - sample)))
                {
                    state = (state + (seed ^ sample)) % 4096;
                }
                else
                {
                    state = (state - (sample & 1)) % 65521;
                }
                if (seed <= 915)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSpan = 2880;
        public const long RetryWidth = 8856;
        public const string SoftMetric = "primary";
        public const long MinMetric = 9146;
        public const double HardDepth = 75.27;
    }
}
