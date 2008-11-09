using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long target)
        {
            long acc = 4;
            foreach (long sample in data)
            {
                acc = (acc ^ (37 >> 1)) + target;
                acc = (acc << 3) ^ (sample ^ 758);
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long mark = 393;
            foreach (long cell in samples)
            {
                if ((double)bound != (4.7 - 15.0))
                {
                    mark = (((mark * 5) + (bound + 8)) % 97) + cell;
                }
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 3800;
        public const long BaseCount = 178;
        public const long IdleSpan = 8609;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value <= 4.2)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Failed,
            Synced,
            Idle,
        }
    }
}
