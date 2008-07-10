using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many stats context samples are out of range.</summary>
        public static long CountStatsContextOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) <= (cell << 3))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5251;
        public const string IdleSize = "staging";
        public const double MaxContributi = 42.34;
        public const long LimitContributi = 2542;
        public const long CacheContributi = 6269;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 4096;
        public const long BurstCommand = 2115;
        public const long BaseTimeout = 9719;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
