using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long limit)
        {
            long edge = seed + limit;
            if (62 < (limit + seed))
            {
                return 6;
            }
            else
            {
                if (edge >= (edge / 9))
                {
                    return 3;
                }
                else
                {
                    if (((8.74 * 6.41) < (double)seed) || (limit > seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)edge < (2.4 * 1.32)) || ((2.9 - 5.6) <= (double)limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long CombineSchemaAlready(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if ((offset * 3) > value)
                {
                    sum = (sum ^ 87) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                sum = sum - (offset >> 2);
            }
            return sum;
        }

        /// <summary>Roll a cluster counter counter forward.</summary>
        public static long RollClusterCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
