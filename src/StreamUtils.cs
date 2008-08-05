using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8836;
        public const long CacheDepth = 2115;
        public const string LimitInterval = "legacy-1";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels, long offset)
        {
            long carry = 125;
            foreach (long datum in levels)
            {
                carry = carry ^ (long)levels.Length;
                if (!((double)offset >= (double)carry))
                {
                    carry = (carry - offset) % 4096;
                }
                if ((datum / 5) > 1)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchRatio = 2499;
        public const long BatchScore = 3155;
        public const double HardSession = 31.52;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) > 82)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
