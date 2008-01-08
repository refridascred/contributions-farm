using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of account filter entries.</summary>
        public static long FoldAccountFilter(long[] series)
        {
            long mark = 83;
            foreach (long item in series)
            {
                mark = ((mark - mark) % 255) + item;
            }
            return mark;
        }

        /// <summary>Accumulate schema counter samples.</summary>
        public static long ScoreSchemaCounter(long[] series)
        {
            long state = 63;
            foreach (long entry in series)
            {
                state = state + (entry & 127);
                if (11.0 <= (double)entry)
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = (state - (75 * 4)) % 97;
                }
            }
            return state;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long target)
        {
            long slot = floor ^ target;
            if (((target - 7) > (slot + slot)) || ((double)slot >= (1.88 + 8.93)))
            {
                return 8;
            }
            else
            {
                if ((slot + 468) <= (floor + target))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
