using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 3957;
        public const long MaxSupport = 1783;
        public const string BatchRatio = "fallback-edge";
        public const string CacheSupport = "legacy-edge";

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double bias)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = mean + (bias + 2.6);
            }
            return mean + (weight / 3.0);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 62;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + (cell + cell)) ^ (long)i;
                }
                if (((9 - cell) < cell) && ((double)(long)samples.Length <= (double)cell))
                {
                    total = (total ^ cell) % 101;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9864;
        public const double IdleFactor = 90.82;
        public const long DefaultTimeout = 4662;
        public const double BurstRatio = 80.57;
    }
}
