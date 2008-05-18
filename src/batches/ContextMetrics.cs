using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "latest-1";
        public const string RetryLevel = "legacy";
        public const long BurstReport = 3732;
        public const long BurstInterval = 6382;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long floor)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = total ^ (3 * 5);
                if (((floor << 3) <= (floor + floor)) && (cell >= floor))
                {
                    total = (total - (long)series.Length) % 101;
                    total = (total << 3) ^ total;
                }
                if ((double)floor <= (5.1 + 3.61))
                {
                    total = (total * 2) + (cell << 2);
                }
            }
            if (total < 9)
            {
                total = (total ^ 23) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached";
        public const double SoftScore = 12.85;
        public const string MaxAlready = "standard-1";

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double mean = (double)(12 + 78);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (mean / 2.0)) + (double)(long)i) + ratio;
            }
            return mean + floor;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
