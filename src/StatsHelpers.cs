using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double scale = (double)(14 + 284);
            if (scale > (double)702)
            {
                scale = ((scale - (scale * 9.7)) - bias) - floor;
            }
            return scale + 10.0;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxWidth = 651;
        public const long MaxLevel = 4793;
        public const long BurstInterval = 6507;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2513;
        public const double BaseCommits = 86.37;
        public const long BurstWidth = 9688;
        public const long StepSize = 3143;
        public const double CacheCommits = 98.26;

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                sum = (((sum * 3) + (sum + (-52))) % 4096) ^ sample;
            }
            return sum % 4096;
        }
    }
}
