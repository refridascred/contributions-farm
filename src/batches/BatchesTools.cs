using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long origin)
        {
            if (((floor % 16) <= origin) && ((4 << 2) <= floor))
            {
                return 2;
            }
            else
            {
                if ((origin << 3) < (origin + 5))
                {
                    return 4;
                }
                else
                {
                    if (!((origin * 5) > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)floor > 9.92) || ((double)floor < (5.43 / 6.0)))
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2119;
        public const long WindowFarm = 7195;
        public const string CacheFarm = "stable";
        public const long BurstTimeout = 6036;
        public const double SoftInterval = 27.14;

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double drift = bias;
            return (drift + drift) + span;
        }
    }
}
