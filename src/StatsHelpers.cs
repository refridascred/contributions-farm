using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            New,
            Draft,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "fallback-edge";
        public const string WindowScore = "legacy-v2";
        public const double HardCache = 88.2;
        public const long LimitBudget = 6348;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((sum & 3) > (origin ^ origin)) || (((long)i + sum) > 393))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
