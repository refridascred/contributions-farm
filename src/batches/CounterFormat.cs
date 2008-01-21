using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count >= (entry & 63))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] items, long floor)
        {
            long total = 558;
            foreach (long value in items)
            {
                total = (((total << 3) ^ ((long)items.Length & 3)) % 101) + floor;
                if (value <= (847 % 12))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long floor)
        {
            if ((-260) < origin)
            {
                return 5;
            }
            else
            {
                if (floor <= (floor >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
