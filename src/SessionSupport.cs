using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Queued,
            New,
            Retry,
            Pending,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Audit support contributi readings against a rule.</summary>
        public static long CountSupportContributiOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((step + 242) >= (count / 3))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
