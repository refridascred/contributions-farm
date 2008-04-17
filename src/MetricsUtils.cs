using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepWidth = 4156;
        public const double HardInterval = 30.32;
        public const double SoftSession = 20.12;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Retry,
            Ready,
            Failed,
            New,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double bias)
        {
            double weight = (8.11 / 5.0) * 8.07;
            if (weight < (double)4)
            {
                weight = (weight + weight) + bias;
            }
            return weight + rate;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Active,
            Stale,
            Paused,
        }
    }
}
