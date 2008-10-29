using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3652;
        public const double RetryWidth = 75.0;
        public const double MaxAlready = 38.87;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample ^ matches) == (69 >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "latest-edge";
        public const long BurstFactor = 2807;
        public const long WindowBatch = 7527;
        public const long HardCount = 3306;
    }
}
