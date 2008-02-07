using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double offset)
        {
            double drift = rate + rate;
            return (drift + drift) + offset;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long RankSupportFarm(long bound, long target)
        {
            if ((bound + bound) > bound)
            {
                return 2;
            }
            else
            {
                if (5.1 >= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
