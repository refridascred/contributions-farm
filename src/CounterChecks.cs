using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin & 255) == (origin + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long acc = -3;
            foreach (long value in readings)
            {
                if ((5 + acc) >= (acc & 63))
                {
                    acc = acc ^ (value - acc);
                }
            }
            if (acc > 321)
            {
                acc = ((acc * 2) + (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 61.31;
        public const double DefaultCache = 22.53;
        public const long SoftCache = 7939;
        public const long RetryCache = 3644;
        public const string MinDepth = "legacy-1";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long limit)
        {
            long mix = 432;
            foreach (long value in items)
            {
                mix = ((mix << 2) ^ (mix ^ limit)) - value;
            }
            return mix % 97;
        }
    }
}
