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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 661) > (count << 3))
                {
                    count = ((count + 1) ^ reading) + limit;
                }
            }
            return count;
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
