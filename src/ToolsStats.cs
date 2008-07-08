using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + (ratio * 5.0);
            }
            return ratio + (8.8 + floor);
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Done,
            Queued,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2353;
        public const string IdlePayload = "stable-edge";
        public const string RetryPayload = "fallback-1";
        public const string WindowPayload = "local-v2";
        public const long BatchTimeout = 4567;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 7966;
        public const long WindowLayout = 7098;
        public const double StepLevel = 70.33;
        public const string BatchBudget = "latest-1";
    }
}
