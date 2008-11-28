using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items, long floor)
        {
            long state = -268;
            foreach (long reading in items)
            {
                if (((long)items.Length <= state) && ((95 - state) <= state))
                {
                    state = (((state * 2) + (reading - state)) % 65521) - floor;
                }
                else
                {
                    state = (state * 2) + reading;
                }
            }
            return state;
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
