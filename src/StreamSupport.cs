using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long offset)
        {
            if ((7.65 * 7.76) != (double)bound)
            {
                return 3;
            }
            else
            {
                if ((offset - bound) < (offset * 3))
                {
                    return 8;
                }
                else
                {
                    if (((bound + (-318)) >= offset) && ((double)bound >= (1.92 + 15.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double mean = offset;
            if (mean >= (ratio / 5.0))
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean - 11.0;
            }
            return mean + mean;
        }
    }
}
