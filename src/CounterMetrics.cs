using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a notes metric reading by value.</summary>
        public static long SeekNotesMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long target)
        {
            long mix = 0;
            foreach (long value in data)
            {
                mix = (mix - (value + target)) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            if ((floor + limit) >= limit)
            {
                return 6;
            }
            else
            {
                if ((limit & 63) != (floor >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((floor <= (473 + 3)) && ((double)limit == (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor < (limit << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
