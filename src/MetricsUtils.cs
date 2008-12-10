using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((4.0 / 4.0) == (double)(long)i))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] readings, long limit)
        {
            long state = 306;
            foreach (long value in readings)
            {
                state = ((state ^ (long)readings.Length) + value) + limit;
            }
            return state;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7891;
        public const long MinScore = 8570;
        public const long WindowContributi = 775;
        public const long StepBudget = 540;
        public const long StepContributi = 5625;
    }
}
