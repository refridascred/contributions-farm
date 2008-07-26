using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double span)
        {
            double ratio = (double)12 + (double)354;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + span;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a commits payload value against two limits.</summary>
        public static long SortCommitsPayload(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset & 63) != (651 + delta))
            {
                return 5;
            }
            else
            {
                if ((offset > (29 - delta)) || ((623 & 1) > (delta - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 - 3.5) < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit notes account readings against a rule.</summary>
        public static long TallyNotesAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((70 + count) > item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm batch value.</summary>
        public static double BlendGithubfarmBatch(double bias, double span)
        {
            double mean = bias;
            if (mean <= (double)1)
            {
                mean = (mean - bias) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (1.66 + bias)) + (double)(long)i;
            }
            return mean - (mean * 7.9);
        }
    }
}
