using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank contributi payload input into a small class.</summary>
        public static long BucketContributiPayload(long offset, long offset2)
        {
            long prev = offset + offset2;
            if (19.0 <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (((offset % 5) <= (prev & 31)) && ((double)offset == (2.73 - 3.0)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate batches entry samples.</summary>
        public static long CombineBatchesEntry(long[] readings, long seed)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                mark = (mark << 3) ^ (seed - value);
                if ((seed ^ value) >= (-532))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark - (-19)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
