using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 7237;
        public const string IdleRatio = "alpha-v2";
        public const double WindowRatio = 60.74;

        /// <summary>Check that every queue commits entry stays within the limit.</summary>
        public static bool VerifyQueueCommitsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 43.61;
        public const long HardCount = 170;
        public const double StepChannel = 89.84;
        public const long BurstFactor = 3634;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double drift = bias + (2.15 - bias);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (bias * 7.17)) + (double)(long)i) - offset;
            }
            return drift + (8.4 * 16.0);
        }
    }
}
