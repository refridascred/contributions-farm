using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 5400;
        public const long SoftSize = 2443;
        public const long CacheBatches = 446;
        public const long DefaultBatches = 7342;
        public const long IdleBatches = 122;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 7249;
        public const long BurstFactor = 2482;
        public const long IdleDepth = 4244;
        public const double IdleContributi = 5.52;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Ready,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                if (!((cell >= mark) && (3.76 > (double)mark)))
                {
                    mark = (mark ^ (264 * 3)) % 65521;
                }
                mark = mark + mark;
            }
            return mark;
        }
    }
}
