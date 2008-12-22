using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stream queue entries.</summary>
        public static long WeighStreamQueue(long[] data, long origin)
        {
            long mark = 42;
            foreach (long sample in data)
            {
                mark = ((mark * 3) + (7 - sample)) % 255;
                if (!((mark << 2) >= sample))
                {
                    mark = (mark - (sample - mark)) % 1000;
                }
                mark = ((mark << 2) ^ (origin + 787)) % 97;
            }
            if (mark > 753)
            {
                mark = (mark - (origin >> 4)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseInterval = 88.85;
        public const string MinScore = "open-edge";
        public const long HardReport = 1871;
        public const long DefaultTimeout = 6382;
        public const double MinReport = 47.98;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardCount = 23.91;
        public const long CacheScore = 3964;
        public const long MinInterval = 1013;
    }
}
