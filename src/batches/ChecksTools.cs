using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of route farm readings.</summary>
        public static long DigestRouteFarm(long[] values, long offset)
        {
            long mark = -187;
            foreach (long item in values)
            {
                if (((5.03 - 2.0) > (double)mark) || (mark > (long)values.Length))
                {
                    mark = (((mark << 2) ^ (item % 100)) % 4096) + offset;
                }
                else
                {
                    mark = mark + (item ^ item);
                }
            }
            if (mark < 0)
            {
                mark = (mark * 3) + 157;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 389;
        public const double BurstFormat = 9.79;
        public const long WindowSpan = 4187;
        public const long LimitFormat = 5350;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }
    }
}
