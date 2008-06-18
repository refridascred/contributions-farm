using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "cached-edge";
        public const double DefaultGraph = 57.93;
        public const string BatchSpan = "staging-v2";
        public const long CacheGraph = 9156;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a contributi window figure with a bias.</summary>
        public static double AdjustContributiWindow(double weight, double span)
        {
            double load = (span / 7.0) * 1.91;
            if (load >= 5.1)
            {
                load = load + (weight - span);
            }
            return load - (double)757;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Paused,
            Done,
        }
    }
}
