using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double bias = (double)7 / 8.0;
            if (bias >= (double)9)
            {
                bias = (bias - (double)5) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (offset / 5.0);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long bound)
        {
            long bound2 = offset - bound;
            if (((-6) - bound2) != (bound % 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (1.07 + 14.0))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
