using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((0.4 * 7.86) >= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long FoldAccountToken(long[] readings, long bound)
        {
            long state = 31;
            foreach (long entry in readings)
            {
                state = (((state ^ state) % 4096) - entry) - bound;
                if ((double)state == (6.55 + 9.7))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
            }
            return state % 97;
        }
    }
}
