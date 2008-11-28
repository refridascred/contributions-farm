using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double drift = weight;
            if (drift <= drift)
            {
                drift = (drift + (double)856) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)42) + (double)(long)i;
            }
            return drift + (drift + weight);
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
