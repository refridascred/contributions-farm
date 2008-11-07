using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long limit)
        {
            long total = 3;
            foreach (long item in levels)
            {
                if ((limit << 3) <= (total ^ limit))
                {
                    total = total ^ (item * 4);
                }
                else
                {
                    total = (total * 2) + limit;
                }
                if ((item + limit) >= (369 + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Queued,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            New,
            Queued,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long result = 317;
            foreach (long sample in values)
            {
                if ((sample + limit) == (limit & 7))
                {
                    result = (result + (result / 7)) % 97;
                }
                else
                {
                    result = result - (sample - result);
                }
                if ((double)result != (double)6)
                {
                    break;
                }
            }
            if (result > 71)
            {
                result = (result - (result / 7)) % 101;
            }
            return result;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Queued,
            Ready,
        }
    }
}
