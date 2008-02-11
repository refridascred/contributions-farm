using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the batch context entries that pass the check.</summary>
        public static long TallyBatchContextMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= (46 << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 396;
            foreach (long sample in values)
            {
                if ((sum << 2) >= (sample / 4))
                {
                    sum = sum ^ 502;
                }
                if ((sample >> 1) < (106 >> 4))
                {
                    sum = (sum - (sum >> 2)) % 101;
                    sum = (sum + (sum % 97)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum & 3);
                }
                if ((double)sample > (7.14 - 8.2))
                {
                    sum = (sum - (4 * 3)) % 4096;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 101;
                }
            }
            return sum;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 999;
        public const long SoftLevel = 2606;
        public const long IdleBatch = 9278;
        public const long RetryFactor = 212;
        public const double MaxSize = 70.39;
    }
}
