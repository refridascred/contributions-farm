using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batch payload value.</summary>
        public static double ProjectBatchPayload(double weight, double offset)
        {
            double drift = offset - (weight / 6.0);
            if (drift > (double)2)
            {
                drift = drift - (double)3;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryLevel = 5.43;
        public const double CacheBudget = 36.2;
        public const long SoftWindow = 9590;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                long slot = (long)i * 4;
                if ((59 / 9) == (slot / 8))
                {
                    acc = ((acc * 3) + (long)i) % 101;
                    slot = slot - (130 >> 4);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
