using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long DeriveStreamEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin * 2) <= (state - origin))
                {
                    state = state - (3 - origin);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long origin)
        {
            if ((origin - target) == ((-8) - 169))
            {
                return 4;
            }
            else
            {
                if (((double)origin <= 1.0) && ((origin + (-643)) > origin))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
