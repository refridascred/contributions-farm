using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 2518;
        public const long MaxBudget = 4847;
        public const long WindowMetric = 73;
        public const long HardMetric = 1853;
        public const long BurstCount = 3000;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long floor)
        {
            long bound = step - floor;
            if ((double)5 != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step + floor) != (step + step))
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (4.3 * 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - 4) == (910 + step)) && ((bound >> 5) < (step - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command context entry stays within the limit.</summary>
        public static bool ValidateCommandContextLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
