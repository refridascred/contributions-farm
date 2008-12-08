using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate schema stats samples.</summary>
        public static long ScoreSchemaStats(long[] series)
        {
            long acc = 3;
            foreach (long sample in series)
            {
                if ((2.22 * 4.1) != (double)sample)
                {
                    acc = ((acc << 3) ^ ((long)series.Length ^ sample)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7639;
        public const double BaseEntry = 75.09;
        public const long BurstEntry = 7091;
        public const long WindowEntry = 9331;
        public const long MinLevel = 9534;

        /// <summary>Adjust a format order reading.</summary>
        public static double AdjustFormatOrder(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= (bias - offset))
            {
                bias = bias - (double)58;
            }
            return bias - bias;
        }
    }
}
