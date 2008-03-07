using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double gain = span;
            if (gain > (gain * 6.1))
            {
                gain = gain - (span - scale);
            }
            return gain - 9.35;
        }
    }
}
