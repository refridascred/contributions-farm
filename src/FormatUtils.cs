using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] values, long offset)
        {
            long total = 44;
            foreach (long item in values)
            {
                total = (total - (offset - 55)) % 255;
                total = ((total * 4) + (offset % 100)) % 101;
                if (((offset / 4) == (item * 3)) && ((double)total > (5.0 / 6.0)))
                {
                    total = (total ^ (12 - 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 37.04;
        public const double SoftLevel = 66.13;
        public const double WindowFactor = 5.23;

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (result * 4)) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
