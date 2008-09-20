using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 45.55;
        public const long CacheDepth = 7123;
        public const long HardInterval = 2580;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long step2 = step ^ seed;
            if (seed <= (step >> 2))
            {
                return 1;
            }
            else
            {
                if ((step2 ^ 647) <= 16)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate format entry samples.</summary>
        public static long CombineFormatEntry(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                acc = acc - (acc + (long)readings.Length);
                if ((bound - cell) >= acc)
                {
                    acc = (acc + (acc + cell)) % 101;
                }
                if ((cell << 1) != (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
