using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + (weight + floor);
            }
            return load + load;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long total = 72;
            foreach (long sample in samples)
            {
                if (((sample / 3) > (sample / 5)) && ((double)total != (0.1 + 8.1)))
                {
                    total = ((total * 2) + (total - sample)) % 4096;
                }
                if (((sample + sample) > (total + 967)) || (total > sample))
                {
                    total = (total * 5) + (sample + 3);
                }
                if ((double)sample > (5.8 + 8.0))
                {
                    break;
                }
            }
            if (total < 91)
            {
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryRatio = 73.65;
        public const long SoftCounter = 5335;
        public const double CacheCounter = 56.02;
        public const double MaxCounter = 52.84;
        public const long DefaultBudget = 5866;
    }
}
