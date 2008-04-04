using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 75.13;
        public const double HardBudget = 18.13;
        public const long BatchLevel = 8814;
        public const long SoftRoute = 775;
    }
}
