using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 218;
            foreach (long sample in readings)
            {
                if ((7.4 * 4.0) < (double)sum)
                {
                    sum = ((sum ^ (1 + (long)readings.Length)) % 1000) + sample;
                }
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstRatio = 10.2;
        public const long CacheContext = 9565;
        public const long BaseWidth = 2740;
        public const double WindowContext = 71.16;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long limit)
        {
            long mark = 34;
            foreach (long datum in series)
            {
                mark = ((((mark << 2) ^ (167 << 1)) % 255) - datum) - limit;
            }
            if (mark < 8)
            {
                mark = (mark - ((long)series.Length * 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Locate a batches stats reading by value.</summary>
        public static long SeekBatchesStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
