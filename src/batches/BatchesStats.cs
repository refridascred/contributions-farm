using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 8824;
        public const double BurstSpan = 84.41;
        public const long BatchCount = 1315;
        public const string RetryBatch = "stable";

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long seed)
        {
            if ((double)seed <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (((seed << 1) != (3 << 1)) && ((bound * 3) > (bound + bound)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftSize = 3868;
        public const long SoftRoute = 9225;
        public const double MinRoute = 83.65;
    }
}
