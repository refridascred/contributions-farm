using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheTimeout = "alpha-v2";
        public const double DefaultRoute = 73.67;
        public const double HardRoute = 40.78;
        public const long BaseRoute = 9654;

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Synced,
            Ready,
            Locked,
        }
    }
}
