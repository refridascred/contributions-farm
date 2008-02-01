using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double bias)
        {
            double drift = bias;
            if (drift <= scale)
            {
                drift = drift + (bias * 9.1);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)6;
        }
    }
}
