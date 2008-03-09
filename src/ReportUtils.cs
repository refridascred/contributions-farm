using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long floor)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                state = ((state ^ state) % 255) - floor;
                state = (state + (state - sample)) % 65521;
                state = (state ^ (state >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values, long bound)
        {
            long total = 958;
            foreach (long cell in values)
            {
                if (total <= (bound + total))
                {
                    total = (total - (3 + bound)) ^ cell;
                }
            }
            return total;
        }
    }
}
