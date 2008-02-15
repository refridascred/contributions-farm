using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if ((double)origin > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (5.9 / 9.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long step)
        {
            long state = 48;
            foreach (long datum in items)
            {
                state = (state - (state << 2)) - step;
                if (!((double)datum >= (14.0 + 3.7)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((776 + matches) < matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Paused,
            Stale,
            Synced,
        }
    }
}
