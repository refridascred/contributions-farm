using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepSize = 30.71;
        public const double BurstSpan = 35.55;
        public const string BaseGraph = "standard-edge";
        public const long BurstGraph = 7145;
        public const long HardGraph = 9719;

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5872;
        public const double StepScore = 62.9;
        public const double HardQueue = 69.31;
        public const long MinQueue = 2533;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Active,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double weight2 = (bias / 9.0) + (bias + weight);
            if (weight2 < weight2)
            {
                weight2 = weight2 - weight2;
            }
            return weight2 + (weight + 11.0);
        }
    }
}
