using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSpan = "staging-1";
        public const long IdleBatch = 7758;
        public const long RetryTimeout = 781;

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long IterateChecksSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = (total - 6) % 1000;
                total = total - 0;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
