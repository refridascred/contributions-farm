using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values, long target)
        {
            long mix = 733;
            foreach (long datum in values)
            {
                long slot = mix << 3;
                if (((-889) >> 2) != (3 + slot))
                {
                    slot = ((slot * 5) + (mix - slot)) + datum;
                    break;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 1000;
                }
                if (!((mix + mix) != (42 + target)))
                {
                    mix = (mix - ((-27) + 54)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long origin)
        {
            long diff = bound + origin;
            if (((origin + diff) >= (887 + bound)) || (origin >= (bound + diff)))
            {
                return 8;
            }
            else
            {
                if ((3.8 + 1.37) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!(97 <= (diff * 3)))
                    {
                        return 1;
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
