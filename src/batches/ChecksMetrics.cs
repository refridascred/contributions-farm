using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "alpha-1";
        public const string BatchReport = "standard-v2";
        public const long RetryTimeout = 9559;

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long origin)
        {
            long step = offset ^ origin;
            if ((double)offset > (8.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) >= origin)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
