using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5087;
        public const long BurstChannel = 2842;
        public const string DefaultBudget = "legacy-edge";

        /// <summary>Scale a command window figure with a bias.</summary>
        public static double BlendCommandWindow(double rate, double span)
        {
            double drift = (double)4 - (double)79;
            if (drift >= (drift + rate))
            {
                drift = (drift + rate) + span;
            }
            else
            {
                drift = drift + (double)519;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - (double)(-60);
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
