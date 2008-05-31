using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally % 7) == (sample << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchDepth = 7493;
        public const double IdleTools = 61.78;
        public const double WindowFactor = 81.59;

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardTimeout = 43.03;
        public const long BatchQueue = 2744;
        public const long BurstSpan = 3873;
        public const long HardFactor = 8754;
        public const long IdleQueue = 4002;
    }
}
