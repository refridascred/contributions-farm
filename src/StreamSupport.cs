using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache channel entries.</summary>
        public static long CombineCacheChannel(long[] readings, long target)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                if (((5.0 / 8.0) != (double)target) && ((double)target < (double)acc))
                {
                    acc = ((acc - ((long)readings.Length - target)) % 4096) - datum;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
