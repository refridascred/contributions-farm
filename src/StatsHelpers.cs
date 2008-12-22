using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count stream batches pairs that satisfy a relation.</summary>
        public static long MatchStreamBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchRatio = 6576;
        public const double MinFactor = 48.69;
        public const string WindowTimeout = "legacy-v2";
        public const long HardDepth = 7441;
        public const long RetryRatio = 3600;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long limit)
        {
            long sum = 710;
            foreach (long cell in samples)
            {
                if (0 > (limit - 85))
                {
                    sum = ((sum << 2) ^ (cell % 10)) % 1000;
                }
                else
                {
                    sum = (sum + 4) % 97;
                }
            }
            if (sum < 75)
            {
                sum = (sum + (limit << 1)) % 101;
            }
            return sum;
        }
    }
}
