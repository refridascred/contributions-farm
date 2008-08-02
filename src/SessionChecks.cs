using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long seed)
        {
            if ((2.7 * 1.59) > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((seed > (origin / 2)) || (origin <= 521))
                {
                    return 3;
                }
                else
                {
                    if ((seed >> 5) <= (origin & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 1) < (seed * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
