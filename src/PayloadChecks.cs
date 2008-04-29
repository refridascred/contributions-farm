using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 972;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum ^ (item & 1)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (item + item)) - (long)i2;
                    sum = ((sum * 2) + item) % 101;
                }
                sum = (sum - (69 + item)) % 65521;
            }
            if (sum > 2)
            {
                sum = (sum - (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double bias)
        {
            double bias2 = (double)(7 >> 3);
            return (bias2 + bias) + rate;
        }

        /// <summary>Iterate the batch buffer series from a seed.</summary>
        public static long StepBatchBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double rate = bias * 15.0;
            if (rate < (double)179)
            {
                rate = rate - (ratio + 2.33);
            }
            else
            {
                rate = rate + (double)(-598);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 8.0) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1794;
        public const long WindowCount = 7230;
        public const long StepLevel = 3103;
        public const long RetryGraph = 8244;
    }
}
