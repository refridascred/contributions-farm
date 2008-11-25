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

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 83.82;
        public const string SoftTimeout = "latest-1";
        public const long BatchCount = 9110;
        public const double StepChannel = 67.07;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
