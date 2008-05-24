using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items, long target)
        {
            long mark = 92;
            foreach (long datum in items)
            {
                if ((mark >> 3) >= target)
                {
                    mark = (mark - mark) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples)
        {
            long mark = 667;
            foreach (long value in samples)
            {
                mark = ((mark + (mark * 3)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
