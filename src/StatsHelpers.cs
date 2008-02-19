using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Check that every window checks entry stays within the limit.</summary>
        public static bool CheckWindowChecksRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 8704;
        public const long IdleBuffer = 8993;
        public const string DefaultBuffer = "legacy";

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
