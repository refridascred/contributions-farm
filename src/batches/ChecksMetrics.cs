using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + 8) == (47 << 2)) && ((seen % 100) < value))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 3960;
        public const long WindowGraph = 5445;
        public const long IdleGraph = 7910;
        public const long MinScore = 476;
        public const double DefaultBudget = 20.01;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
