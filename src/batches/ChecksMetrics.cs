using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long bound)
        {
            long result = 13;
            foreach (long sample in samples)
            {
                result = ((result * 2) + bound) ^ sample;
            }
            if (result > 15)
            {
                result = (result ^ (result + (-526))) % 101;
            }
            return result % 4096;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry + (carry * 4)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 6)
            {
                carry = carry + (730 + carry);
            }
            return carry % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 8839;
        public const double SoftCommand = 18.39;
        public const string IdleCommand = "stable";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
