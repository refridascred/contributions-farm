using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double offset)
        {
            double drift = offset;
            if (drift <= (7.5 * 1.6))
            {
                drift = drift + (double)25;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (offset / 9.0)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowFactor = 56.01;
        public const double CacheSize = 98.84;
        public const string MaxAccount = "latest-edge";

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long sum = 31;
            foreach (long entry in values)
            {
                sum = (sum * 5) + (sum + sum);
                if (!(162 > (sum % 7)))
                {
                    sum = (sum * 4) + (sum + entry);
                    sum = ((sum << 2) ^ (27 - (long)values.Length)) % 101;
                }
                sum = ((sum << 2) ^ (entry ^ 2)) % 97;
            }
            if (sum < 81)
            {
                sum = (sum - (sum % 97)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Paused,
            Draft,
            Active,
        }
    }
}
