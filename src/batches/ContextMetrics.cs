using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long CountFarmCommandHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((9 ^ tally) >= (limit % 64))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a batch token reading by value.</summary>
        public static long LocateBatchTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 5198;
        public const long MinWidth = 5306;
        public const long IdleTools = 9647;
        public const long LimitRatio = 9382;
    }
}
