using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a context order reading by value.</summary>
        public static long FindContextOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long seed)
        {
            long lane = step + seed;
            if (!(seed < step))
            {
                return 0;
            }
            else
            {
                if ((seed + lane) < (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 4) == (99 - 40)) || (61 >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((950 + step) < (step ^ lane))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
