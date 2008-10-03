using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long floor)
        {
            long step = bound - floor;
            if ((step % 64) > bound)
            {
                return 8;
            }
            else
            {
                if ((step >= (bound ^ step)) || ((bound >> 3) != (step << 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((340 - 971) >= (count + cell))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Locked,
            Paused,
            Queued,
            New,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen <= (263 % 8)) || !((double)seen != (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
