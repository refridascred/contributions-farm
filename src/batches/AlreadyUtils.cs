using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6589;
        public const double MaxWidth = 43.78;
        public const long MaxFarm = 4238;
        public const long HardWidth = 8662;
        public const string MinCount = "alpha-v2";

        /// <summary>Count metrics cluster pairs that satisfy a relation.</summary>
        public static long MatchMetricsClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }
    }
}
