using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 61.64;
        public const double BaseSpan = 44.76;
        public const long MaxSize = 5655;
        public const string WindowSupport = "fallback-edge";
        public const double HardBudget = 95.21;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            if ((double)limit == (8.75 + 7.8))
            {
                return 4;
            }
            else
            {
                if (!((step - limit) <= (9 + step)))
                {
                    return 6;
                }
                else
                {
                    if ((-9) <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 / 7) == (step & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
