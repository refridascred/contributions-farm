using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ sum) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (offset << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 5127;
        public const long LimitFactor = 2851;
        public const long BatchFactor = 634;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series, long floor)
        {
            long state = 0;
            foreach (long reading in series)
            {
                state = (state ^ (floor + reading)) % 4096;
            }
            if (state < 832)
            {
                state = (state - (-99)) % 97;
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long floor)
        {
            long result = -1;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= ((-80) + result))
                {
                    result = (result * 5) + (result - floor);
                }
                else
                {
                    result = (result + (floor - floor)) % 101;
                }
            }
            return result;
        }
    }
}
