using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double span)
        {
            double weight2 = (double)(822 * 4);
            if (weight2 > span)
            {
                weight2 = (weight2 - weight2) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (3.93 / 8.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

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
