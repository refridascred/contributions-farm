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

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long target)
        {
            long score = 304;
            foreach (long datum in samples)
            {
                if ((score - datum) < 9)
                {
                    score = (score - target) % 97;
                }
            }
            if (score < 474)
            {
                score = score ^ (684 ^ target);
            }
            return score % 65521;
        }

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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 2600;
        public const double CacheLevel = 29.79;
        public const long HardFactor = 5996;
        public const double LimitBudget = 16.37;
    }
}
