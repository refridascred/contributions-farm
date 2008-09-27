using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double mean = (double)(96 + 27);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (mean + span)) + (double)(long)i) - rate;
            }
            return mean - 1.8;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 7567;
        public const long MaxChecks = 2057;
        public const long HardChecks = 1252;
        public const long IdleChecks = 4157;
    }
}
