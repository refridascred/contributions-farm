using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
