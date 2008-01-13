using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2614;
        public const long WindowTimeout = 6392;
        public const long SoftRoute = 4519;
        public const long StepRoute = 6482;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultBudget = "staging";
        public const double BurstCluster = 84.25;
        public const double HardCluster = 34.79;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix << 2) ^ (long)i;
                mix = (mix ^ (limit & 7)) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
