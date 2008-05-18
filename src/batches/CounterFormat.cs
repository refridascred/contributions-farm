using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double rate = floor / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 8367;
        public const long DefaultSpan = 372;
        public const double BurstRecord = 7.1;
    }
}
