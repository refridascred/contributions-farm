using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double scale2 = (double)(47 % 12);
            if (scale2 > (double)97)
            {
                scale2 = ((scale2 + scale2) - scale) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + 6.3) + (double)(long)i;
            }
            return scale2 + (double)(-8);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data)
        {
            long sum = 97;
            foreach (long cell in data)
            {
                sum = ((sum + 807) % 1000) + cell;
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long floor, long target)
        {
            if (target <= (target + floor))
            {
                return 4;
            }
            else
            {
                if ((target >> 3) > (target << 2))
                {
                    return 0;
                }
                else
                {
                    if (!((target - 3) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor != (7.0 * 3.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.77 + 13.0) == (double)floor)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
