using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two order batch measurements.</summary>
        public static double ScaleOrderBatch(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < bias2)
            {
                mean = (mean - bias2) + bias;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (5.53 * 2.8);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long target)
        {
            long next = floor - target;
            if (target < (target % 64))
            {
                return 3;
            }
            else
            {
                if (((double)794 > (double)floor) || ((double)869 >= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if (target < (next / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstBudget = 84.9;
        public const string BaseStats = "fallback-edge";
        public const long IdleFactor = 7848;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value ^ target) > (target + target))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double weight = bias;
            return (weight - (double)1) + span;
        }
    }
}
