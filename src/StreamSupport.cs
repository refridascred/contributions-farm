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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long origin)
        {
            long next = floor + origin;
            if ((next + origin) < (next / 4))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (2.38 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if (689 > (origin * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
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
