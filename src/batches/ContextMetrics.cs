using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long MeasureStatsGithubfarmHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally >= (double)sample)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Rank token record input into a small class.</summary>
        public static long RankTokenRecord(long bound, long bound2)
        {
            if (((bound2 + bound) > (82 * 2)) || ((4.0 / 8.0) < (double)bound2))
            {
                return 0;
            }
            else
            {
                if ((bound - bound2) != (bound2 << 1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > rate)
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)148) + (double)(long)i;
            }
            return rate - offset;
        }
    }
}
