using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a editor channel counter forward.</summary>
        public static long DeriveEditorChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

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
