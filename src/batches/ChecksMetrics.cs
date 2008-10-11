using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 11.45;
        public const long DefaultGraph = 4651;
        public const string SoftGraph = "cached-v2";
        public const long LimitRatio = 3715;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long seed, long bound)
        {
            if (bound < seed)
            {
                return 7;
            }
            else
            {
                if (((seed - seed) <= (bound ^ seed)) && ((seed ^ bound) >= (bound + 795)))
                {
                    return 8;
                }
                else
                {
                    if (!((bound - 4) >= (bound << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed / 4) != (seed ^ 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 4456;
        public const long BatchLevel = 5956;
        public const long CacheQueue = 7624;

        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool ValidateLayoutContributiLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (8.36 / 8.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
