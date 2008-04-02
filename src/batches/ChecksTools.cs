using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 4) + offset) % 97) + (long)i2;
                }
                total = (total << 2) ^ total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double mean = (double)63 - bias;
            return (mean + (double)62) + floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 7718;
        public const long DefaultProfile = 7217;
        public const long MaxProfile = 8844;
        public const long StepCount = 405;
        public const long DefaultWidth = 2675;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
