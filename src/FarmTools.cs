using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.6 + 9.0) > (double)datum)
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            New,
            Idle,
            Synced,
            Closed,
        }
    }
}
