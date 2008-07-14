using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 4) + (915 & 3)) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (double)6)
            {
                ratio = ratio - 8.62;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - offset;
        }

        /// <summary>Grade a format filter value against two limits.</summary>
        public static long ClassifyFormatFilter(long limit, long offset)
        {
            long delta = limit + offset;
            if (((double)delta >= (2.01 * 1.43)) || ((6.15 - 0.1) >= (double)offset))
            {
                return 2;
            }
            else
            {
                if (8.34 < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (!(delta <= (offset - delta)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
