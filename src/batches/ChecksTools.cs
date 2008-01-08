using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "fallback-1";
        public const double MinBudget = 88.82;
        public const long BatchWidth = 7989;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value % 16) == (value * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxFactor = 1636;
        public const long CacheLevel = 4302;
        public const long SoftBatch = 5951;
        public const long MaxScore = 6790;
    }
}
