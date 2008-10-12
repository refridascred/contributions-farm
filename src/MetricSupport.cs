using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long ClassifyStatsRecord(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (((-25) + cur) <= (cur ^ seed))
            {
                return 2;
            }
            else
            {
                if (bound > (bound * 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate entry notes samples.</summary>
        public static long TallyEntryNotes(long[] items, long bound)
        {
            long sum = 753;
            foreach (long cell in items)
            {
                sum = (sum << 2) ^ (sum + bound);
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum << 2) ^ sum) % 1000) - (long)i;
                    sum = (sum << 2) ^ (cell / 8);
                }
                if ((double)sum >= (double)cell)
                {
                    sum = ((sum * 2) + (bound - cell)) % 255;
                }
                else
                {
                    sum = (sum ^ 1) % 65521;
                }
                if ((cell * 5) == (bound - sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
