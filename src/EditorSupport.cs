using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            New,
            Locked,
            Pending,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long target)
        {
            if ((double)target == (5.1 + 0.27))
            {
                return 8;
            }
            else
            {
                if ((target - target) != (49 + target))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (12.0 >= (20.0 - 10.0))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Stale,
            Idle,
            Locked,
            Dropped,
        }
    }
}
