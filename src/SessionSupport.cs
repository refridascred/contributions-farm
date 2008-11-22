using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stats tools pair into a bucket.</summary>
        public static long RankStatsTools(long limit, long bound)
        {
            if (((bound ^ limit) > (bound * 3)) && ((double)limit != (2.59 + 3.69)))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) != (limit * 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "standard-v2";
        public const long LimitWidth = 30;
        public const long MaxFactor = 6966;

        /// <summary>Project the next buffer contributi value.</summary>
        public static double BlendBufferContributi(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate + (weight * 0.5);
            }
            return rate + (double)856;
        }
    }
}
