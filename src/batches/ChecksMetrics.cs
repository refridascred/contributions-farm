using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stream command samples.</summary>
        public static long CombineStreamCommand(long[] items, long offset)
        {
            long carry = 37;
            foreach (long item in items)
            {
                if ((offset + item) > 57)
                {
                    carry = carry - item;
                }
                else
                {
                    carry = carry + 4;
                }
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((double)hits <= (2.0 * 3.6)) && ((value + hits) < (hits % 3))) && (hits <= (hits << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile token sample.</summary>
        public static long FindProfileTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long floor)
        {
            long state = 5;
            foreach (long sample in levels)
            {
                if ((double)sample != (12.0 * 17.0))
                {
                    state = state - floor;
                }
            }
            if (state < 449)
            {
                state = ((state << 2) ^ (floor + (-29))) % 255;
            }
            return state;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
