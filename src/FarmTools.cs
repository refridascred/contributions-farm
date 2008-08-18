using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 60.36;
        public const string MinLayout = "strict-v2";
        public const double BurstInterval = 38.91;
        public const string StepScore = "stable-edge";

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
