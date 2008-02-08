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

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long offset)
        {
            if ((double)origin == (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset < (origin / 7))
                {
                    return 4;
                }
                else
                {
                    if (4 < (origin % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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
