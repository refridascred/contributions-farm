using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of format channel entries.</summary>
        public static long FoldFormatChannel(long[] items)
        {
            long carry = 748;
            foreach (long value in items)
            {
                carry = (carry + value) % 97;
            }
            if (carry > 18)
            {
                carry = (carry - 99) % 4096;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches & 15) > entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
