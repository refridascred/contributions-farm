using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 2943;
        public const long SoftMetrics = 1224;
        public const long BaseMetrics = 5119;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long ScoreAlreadySession(long[] series)
        {
            long result = 76;
            foreach (long reading in series)
            {
                result = (((result << 2) ^ (6 >> 5)) % 255) - reading;
            }
            return result;
        }
    }
}
