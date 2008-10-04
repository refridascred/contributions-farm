using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double load = (double)(676 >> 5);
            return ((load - (double)(-523)) + weight) + bias;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double load = (double)((-976) - 19);
            if (load >= scale)
            {
                load = load - load;
            }
            else
            {
                load = load - (load + span);
            }
            return load + (span * 0.98);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long origin)
        {
            if ((offset + origin) >= (offset + offset))
            {
                return 2;
            }
            else
            {
                if (((1.0 / 7.0) >= (double)offset) && ((2.0 - 3.34) > (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
