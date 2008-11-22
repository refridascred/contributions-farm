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

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultBudget = 2255;
        public const double WindowFactor = 59.55;
        public const string StepQueue = "stable-v2";
        public const long RetryInterval = 3709;

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
