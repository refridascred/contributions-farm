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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = state + (limit / 5);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

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
