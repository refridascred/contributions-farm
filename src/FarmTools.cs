using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Ready,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Pending,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long bound = offset - target;
            if ((target / 2) <= (893 ^ bound))
            {
                return 2;
            }
            else
            {
                if (1.0 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
