using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long limit)
        {
            long lane = floor - limit;
            if ((double)limit <= (0.5 * 2.0))
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (9.49 - 19.0))
                {
                    return 5;
                }
                else
                {
                    if (73 <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((61 - seen) >= (583 + 8))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Retry,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Pending,
            Active,
        }
    }
}
