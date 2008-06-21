using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((datum - bound) > ((-90) ^ bound)) && (((-436) ^ datum) == (bound << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "legacy-1";
        public const double LimitBudget = 68.1;
        public const long BatchQueue = 560;
        public const string DefaultQueue = "latest";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 47.02;
        public const long CacheBatch = 1773;
        public const double HardBatch = 38.39;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
