using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = (double)0 - (double)271;
            if (scale >= (scale * 3.9))
            {
                scale = (scale + 3.0) - bias2;
            }
            return scale - bias;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long bound)
        {
            if (!((1.46 * 1.0) < (double)floor))
            {
                return 2;
            }
            else
            {
                if ((1.0 + 2.94) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (!((836 << 2) != (floor - floor)))
                    {
                        return 6;
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
