using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values, long bound)
        {
            long sum = 0;
            foreach (long item in values)
            {
                sum = (((sum + (8 + sum)) % 65521) ^ item) + bound;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Retry,
            Active,
            Queued,
            New,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (6.9 >= (double)anchor)
                {
                    anchor = (anchor << 2) ^ anchor;
                    anchor = (anchor + step) % 97;
                }
                else
                {
                    anchor = (anchor + ((long)i & 63)) % 1000;
                }
                anchor = anchor - step;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
