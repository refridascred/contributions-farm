using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double bias)
        {
            double scale = (7.18 - bias) * 5.5;
            if (scale <= (scale / 8.0))
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - (bias / 5.0);
            }
            return scale + (9.6 * 19.0);
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long FindFarmSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm format pair into a bucket.</summary>
        public static long GradeFarmFormat(long seed, long seed2)
        {
            if (seed2 >= (seed2 & 1))
            {
                return 0;
            }
            else
            {
                if ((seed2 + seed2) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total << 2) ^ (total >> 5)) ^ (long)i2;
                    total = (total - (total + target)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
