using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            New,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings)
        {
            long result = 0;
            foreach (long value in readings)
            {
                if ((double)result <= (7.05 * 4.6))
                {
                    result = ((result + result) % 101) ^ value;
                }
            }
            return result % 1000;
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
