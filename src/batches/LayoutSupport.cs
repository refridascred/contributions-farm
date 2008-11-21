using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mark = 9;
            foreach (long reading in levels)
            {
                mark = ((mark * 2) + reading) % 4096;
            }
            if (mark > 474)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Idle,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Synced,
            Dropped,
        }
    }
}
