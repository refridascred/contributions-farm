using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 6723;
        public const long IdleEntry = 9657;
        public const double MaxEntry = 18.83;
        public const long BurstEntry = 2953;
        public const long CacheRatio = 3426;

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                if (anchor <= target)
                {
                    anchor = anchor + (target - anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate batch buffer samples.</summary>
        public static long FoldBatchBuffer(long[] items, long bound)
        {
            long state = 191;
            foreach (long sample in items)
            {
                if (((66 >> 1) != (state + bound)) && (state >= (sample + sample)))
                {
                    state = state ^ bound;
                }
                else
                {
                    state = (state + (state % 16)) % 101;
                }
            }
            return state;
        }
    }
}
