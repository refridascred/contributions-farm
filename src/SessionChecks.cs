using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values)
        {
            long acc = 84;
            foreach (long datum in values)
            {
                if ((acc ^ acc) <= (datum & 3))
                {
                    acc = ((acc * 2) + (acc >> 3)) % 4096;
                }
                else
                {
                    acc = (acc ^ (datum << 2)) % 101;
                }
            }
            if (acc < 87)
            {
                acc = ((acc * 2) + (acc % 7)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            New,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Failed,
            Dropped,
            Draft,
        }
    }
}
