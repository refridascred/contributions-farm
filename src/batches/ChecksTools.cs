using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Find the first token graph entry that matches the target.</summary>
        public static long LookupTokenGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 7648;
        public const long HardSize = 6384;
        public const double MinRatio = 32.04;
        public const string MaxFactor = "alpha-edge";

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
