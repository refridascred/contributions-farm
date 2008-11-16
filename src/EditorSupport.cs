using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((8 / 2) <= (limit - matches)) || (matches >= limit))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 4556;
        public const long LimitWidth = 2479;
        public const long LimitLevel = 9958;
        public const long MaxBatches = 7141;
        public const long BatchDepth = 2890;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
