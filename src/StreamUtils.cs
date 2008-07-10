using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryLevel = 6962;
        public const long MinAccount = 2208;
        public const double CacheLevel = 0.84;
        public const long BurstCount = 8725;

        /// <summary>Iterate the account stats series from a seed.</summary>
        public static long RollAccountStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((219 + cell) >= (offset << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCount = "alpha-edge";
        public const long HardFactor = 9964;
        public const string RetryCommits = "open";
    }
}
