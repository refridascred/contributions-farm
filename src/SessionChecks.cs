using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long origin)
        {
            long carry = 101;
            foreach (long sample in samples)
            {
                if ((328 - carry) <= origin)
                {
                    break;
                }
                if (origin > (sample & 3))
                {
                    carry = (carry - origin) % 1000;
                }
                else
                {
                    carry = (carry * 2) + (carry << 2);
                }
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary";
        public const long BaseBudget = 7284;
        public const long RetryLevel = 6348;
        public const double WindowCounter = 32.65;
        public const long WindowCount = 8690;

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long CountBatchFilterHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits > 64)
                {
                    hits = ((hits + 2) + sample) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double ratio = (double)(9 % 16);
            if (ratio > weight)
            {
                ratio = (ratio + weight) - span;
            }
            else
            {
                ratio = ratio - (double)72;
            }
            return ratio + 6.91;
        }
    }
}
