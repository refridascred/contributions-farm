using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items, long offset)
        {
            long mark = -45;
            foreach (long entry in items)
            {
                if ((12.0 * 0.44) == (double)entry)
                {
                    mark = ((mark << 3) ^ (entry + mark)) % 97;
                }
                if ((offset % 64) < (entry - entry))
                {
                    mark = mark - (entry % 12);
                }
            }
            if (mark > 48)
            {
                mark = ((mark << 3) ^ (8 ^ mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long total = 1;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (17.0 * 10.0)))
                {
                    total = (total * 3) + (36 - (long)readings.Length);
                }
                if ((double)seed <= 0.17)
                {
                    total = (total - (3 >> 1)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total << 1)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long MeasureOrderCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((double)seen <= (18.0 + 10.0)) || ((4.59 + 2.59) > (double)datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm command value against two limits.</summary>
        public static long BucketGithubfarmCommand(long floor, long bound)
        {
            if ((97 >= (floor ^ 79)) && ((floor >> 5) > (floor << 1)))
            {
                return 5;
            }
            else
            {
                if ((floor + 696) <= (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 2) < (bound - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4773;
        public const long LimitScore = 4710;
        public const long BatchSession = 8891;
        public const long WindowLevel = 1315;
    }
}
