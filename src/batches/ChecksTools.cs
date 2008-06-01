using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            New,
            Idle,
            Active,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double offset)
        {
            double mean = bias;
            if (mean < (mean * 11.0))
            {
                mean = mean - (mean - offset);
            }
            else
            {
                mean = mean + (double)767;
            }
            return mean - (7.2 - mean);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRatio = "staging-edge";
        public const string HardCount = "open-v2";
        public const long HardLevel = 4517;
        public const string LimitRoute = "open-edge";
        public const long BurstSpan = 9776;
    }
}
