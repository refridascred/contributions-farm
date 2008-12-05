using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seed + seen) <= (seen * 3))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 6846;
        public const long BatchFormat = 6703;
        public const long StepScore = 5297;
        public const string IdleTimeout = "primary-v2";
        public const long StepFormat = 3451;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinCount = "standard-v2";
        public const long MinFormat = 7108;
        public const string MaxSize = "cached-edge";
        public const long DefaultFormat = 5260;
        public const long RetryFormat = 5812;

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double bias3 = (4.2 / 6.0) + bias2;
            if (bias3 < bias3)
            {
                bias3 = (bias3 - (double)1) - bias;
            }
            return bias3 + (double)66;
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long FoldQueueNotes(long[] samples)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                if (!((sum + (-51)) != (sum / 9)))
                {
                    sum = sum - (value + (-418));
                }
            }
            return sum;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            if ((floor + target) < (23 << 3))
            {
                return 1;
            }
            else
            {
                if ((target << 3) <= (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
