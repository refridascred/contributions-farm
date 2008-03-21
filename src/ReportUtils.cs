using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = (double)57;
            return ((weight - (double)87) + scale) + floor;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long floor, long bound)
        {
            if (floor < (floor / 3))
            {
                return 1;
            }
            else
            {
                if (((317 / 4) >= floor) || ((double)floor >= (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (double)8)
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "primary-edge";
        public const double MinToken = 43.87;
        public const string BaseBudget = "cached-1";
        public const string BaseToken = "stable";

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 86.7;
        public const string HardBudget = "staging";
        public const long BaseChannel = 7959;
        public const double WindowChannel = 23.51;
    }
}
