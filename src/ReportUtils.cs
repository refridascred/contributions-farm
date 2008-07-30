using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mark = 993;
            foreach (long sample in levels)
            {
                long matches = (sample / 3) - (sample - mark);
                if (14.0 > (double)matches)
                {
                    matches = matches ^ (sample - mark);
                }
                if ((double)mark <= (9.05 * 5.0))
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 1511;
        public const double HardOrder = 95.72;
        public const long BatchInterval = 6602;
        public const long IdleWidth = 394;
        public const long BaseOrder = 4563;

        /// <summary>Grade a graph metric value against two limits.</summary>
        public static long GradeGraphMetric(long floor, long target)
        {
            if (!((double)floor >= (double)target))
            {
                return 1;
            }
            else
            {
                if ((9 + floor) != (floor % 100))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (8.21 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 1192;
        public const double LimitScore = 16.21;
        public const long IdleCount = 5362;
        public const double IdleScore = 10.2;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
