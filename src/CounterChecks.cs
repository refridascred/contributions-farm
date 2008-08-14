using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long limit)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if ((sample + state) <= sample)
                {
                    state = state - limit;
                }
            }
            return state;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 246;
            foreach (long item in items)
            {
                if ((mark * 4) > mark)
                {
                    mark = (mark - 88) % 1000;
                }
                if (((mark % 7) > (mark - item)) || ((item - item) <= (mark / 8)))
                {
                    break;
                }
            }
            if (mark < 3)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long AuditBatchesEditorMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (limit + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Grade a queue filter value against two limits.</summary>
        public static long SortQueueFilter(long limit, long target)
        {
            long cur = limit - target;
            if (cur < (target / 5))
            {
                return 0;
            }
            else
            {
                if ((cur << 3) == (112 >> 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
