using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data, long target)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ mix) - entry;
                mix = (mix - (target + mix)) % 1000;
            }
            if (mix < 58)
            {
                mix = (mix + target) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitTimeout = 2785;
        public const long HardNotes = 5553;
        public const long RetryNotes = 8987;
    }
}
