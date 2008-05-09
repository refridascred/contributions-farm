using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of tools metric readings.</summary>
        public static long CombineToolsMetric(long[] items)
        {
            long acc = 989;
            foreach (long value in items)
            {
                acc = (acc * 2) + (value >> 3);
            }
            return acc;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if (((double)bound >= 12.0) || ((9 - target) > bound))
            {
                return 6;
            }
            else
            {
                if (((target * 4) > bound) || (target > (203 >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((target - (-36)) == (bound ^ bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((2 ^ bound) < (bound + target)) || ((bound + bound) != (target / 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
