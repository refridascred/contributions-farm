using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long limit, long target)
        {
            long step = limit + target;
            if ((limit <= (limit << 2)) && ((limit + limit) >= 87))
            {
                return 8;
            }
            else
            {
                if (target <= (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 5) == (limit + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
