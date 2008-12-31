using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue stream readings against a rule.</summary>
        public static long MeasureQueueStreamMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits % 100) >= (hits & 3)))
                {
                    hits = ((hits + 2) + value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Grade a account session value against two limits.</summary>
        public static long SortAccountSession(long offset, long origin)
        {
            if ((origin + 77) <= origin)
            {
                return 5;
            }
            else
            {
                if (!((30 * 4) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (0 > (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((86 >> 4) <= (origin - offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double scale2 = bias - (2.99 * 3.4);
            return (scale2 - (scale2 * 2.21)) + scale;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen % 5) > (value << 2))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
