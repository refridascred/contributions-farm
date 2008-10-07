using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxLevel = 3921;
        public const double SoftWidth = 59.98;
        public const string HardMetric = "latest-1";

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mark = 583;
            foreach (long cell in samples)
            {
                if ((mark + cell) != (mark >> 1))
                {
                    mark = (mark - (61 % 24)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 4) + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double drift = (double)(11 + 8);
            if (drift > (0.6 + bias))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (span - drift)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.6 + 9.2) >= (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
