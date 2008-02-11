using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] data)
        {
            long sum = 232;
            foreach (long sample in data)
            {
                if (((sum << 3) < (67 << 3)) || ((1.2 / 5.0) != (double)sum))
                {
                    sum = ((sum * 5) + ((-691) & 15)) % 1000;
                }
                else
                {
                    sum = (sum + (75 ^ sample)) % 255;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double weight = bias;
            if (weight > (2.0 * 16.0))
            {
                weight = (weight - 8.47) + scale;
            }
            else
            {
                weight = weight - (bias * 8.0);
            }
            return weight - (double)5;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 26.23;
        public const double RetryBudget = 70.67;
        public const double BaseCount = 8.22;
        public const long StepTimeout = 8466;
        public const string BatchSize = "strict-edge";

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double ratio = (double)359;
            return ((ratio + 1.4) + bias) + span;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long target)
        {
            if ((4 + floor) <= (target - target))
            {
                return 0;
            }
            else
            {
                if ((target + target) >= (target + 76))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
