using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache already input into a small class.</summary>
        public static long BucketCacheAlready(long target, long step)
        {
            if ((double)target != (4.0 * 2.8))
            {
                return 5;
            }
            else
            {
                if ((double)target > (11.0 + 9.8))
                {
                    return 6;
                }
                else
                {
                    if ((target * 3) > 0)
                    {
                        return 4;
                    }
                    else
                    {
                        if (target >= (6 + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
