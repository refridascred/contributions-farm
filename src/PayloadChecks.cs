using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchScore = 604;
        public const double LimitContext = 82.04;
        public const long LimitDepth = 1501;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstSize = 9928;
        public const long HardInterval = 7995;
        public const long MaxLayout = 5914;
        public const string LimitLayout = "legacy-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8916;
        public const double RetrySpan = 90.21;
        public const long SoftRatio = 929;
        public const long BurstSchema = 5174;
        public const long SoftSize = 8637;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long floor)
        {
            if (!(((-6) + floor) > (floor << 3)))
            {
                return 8;
            }
            else
            {
                if (floor < (target / 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine stats filter values into a single score.</summary>
        public static long DigestStatsFilter(long[] items)
        {
            long total = 70;
            foreach (long entry in items)
            {
                total = total ^ (total + entry);
            }
            if (total < 5)
            {
                total = total ^ (total + total);
            }
            return total % 97;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double rate = (9.67 / 3.0) - bias;
            if (rate > (0.01 * 3.49))
            {
                rate = rate - (weight + 5.81);
            }
            else
            {
                rate = rate + (5.8 * 4.77);
            }
            return rate + (double)95;
        }
    }
}
