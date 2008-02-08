using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 3133;
        public const double RetryFilter = 61.27;
        public const long BurstSize = 9129;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long target)
        {
            long diff = bound - target;
            if ((bound % 7) >= bound)
            {
                return 3;
            }
            else
            {
                if ((bound ^ 43) <= (diff << 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
