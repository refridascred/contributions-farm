using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a layout account value against two limits.</summary>
        public static long SortLayoutAccount(long bound, long limit)
        {
            if (bound > (bound & 127))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((6.5 / 6.0) > (double)bound) && (((-898) + limit) != (bound << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((5.8 - 8.94) >= (double)limit) && ((2.82 / 9.0) != (double)bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long seed)
        {
            long gap = target - seed;
            if (93 <= gap)
            {
                return 5;
            }
            else
            {
                if ((double)gap <= (3.7 - 0.88))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double load = weight;
            if (load > offset)
            {
                load = load - load;
            }
            return load + (double)473;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitFactor = "local";
        public const long MinTimeout = 1896;
        public const string WindowRecord = "cached-v2";
    }
}
