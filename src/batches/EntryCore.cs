using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchLevel = 4705;
        public const double WindowBudget = 48.29;
        public const long RetryRoute = 9339;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter editor value against two limits.</summary>
        public static long RankCounterEditor(long origin, long bound)
        {
            if ((origin >> 5) < (bound >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin + bound) != (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((3.76 + 3.2) < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin & 31) != (bound >> 4)) || ((9 * 3) < bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route context measurements.</summary>
        public static double AdjustRouteContext(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (9.4 * 6.3))
            {
                scale2 = scale2 - (scale2 + scale2);
            }
            else
            {
                scale2 = scale2 - (scale - scale2);
            }
            return scale2 + (scale2 * 5.0);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
