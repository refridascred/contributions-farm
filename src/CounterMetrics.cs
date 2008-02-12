using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowBudget = 36.95;
        public const double MinSchema = 53.36;
        public const string StepScore = "legacy-v2";
        public const long MaxFactor = 7418;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long limit)
        {
            long bound = origin ^ limit;
            if (!((limit + bound) < (origin + bound)))
            {
                return 4;
            }
            else
            {
                if ((limit / 3) > bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias)
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 - (3.3 + 7.0);
            }
            return bias2 + bias2;
        }
    }
}
