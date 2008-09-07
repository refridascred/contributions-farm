using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long target)
        {
            if (((1.53 - 1.37) <= (double)target) || ((target - 57) != (seed + target)))
            {
                return 1;
            }
            else
            {
                if ((77 - target) != ((-2) / 9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
