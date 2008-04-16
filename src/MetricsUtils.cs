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

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                if ((bound & 31) == (sample ^ 32))
                {
                    score = (score - score) % 101;
                }
            }
            if (score > 219)
            {
                score = score ^ 324;
            }
            return score;
        }

        /// <summary>Rank order format input into a small class.</summary>
        public static long SortOrderFormat(long step, long step2)
        {
            long bound = step - step2;
            if ((805 / 8) != (step2 - step))
            {
                return 3;
            }
            else
            {
                if (!((bound >> 5) >= (step + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((403 + step2) >= (989 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
