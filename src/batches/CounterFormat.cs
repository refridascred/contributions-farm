using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long step)
        {
            if ((floor * 4) >= (floor << 1))
            {
                return 5;
            }
            else
            {
                if (6.64 <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((floor + 32) < (floor << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double scale = (double)((-240) + 4);
            if (scale >= bias)
            {
                scale = (scale + (scale * 1.78)) - span;
            }
            return scale - scale;
        }
    }
}
