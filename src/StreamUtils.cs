using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowFactor = 9636;
        public const long BurstSchema = 1176;
        public const double IdleSchema = 38.11;
        public const long WindowTimeout = 7150;
        public const long RetryScore = 3414;

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double rate, double bias)
        {
            double bias2 = 2.85;
            if (bias2 <= (double)6)
            {
                bias2 = (bias2 + bias) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias2 - bias)) + (double)(long)i;
            }
            return bias2 - 4.38;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
