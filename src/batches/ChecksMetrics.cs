using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Ready,
            Retry,
            New,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseDepth = 1382;
        public const long BurstTimeout = 296;
        public const long BurstContributi = 6248;
        public const string CacheWidth = "staging-edge";

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long TallyMetricCacheMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((7 & 1) <= (seen ^ bound))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinScore = 5875;
        public const long MinLevel = 9451;
        public const long HardCount = 6031;
        public const long MaxAlready = 4946;
        public const string HardAlready = "open-v2";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            New,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = ((result - result) + item) + offset;
            }
            return result;
        }
    }
}
