using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long seed)
        {
            long span = origin ^ seed;
            if (seed <= span)
            {
                return 7;
            }
            else
            {
                if ((351 - seed) == (seed - 49))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long seed)
        {
            long offset = origin - seed;
            if ((offset >> 2) < (origin + offset))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) >= (offset / 2))
                {
                    return 4;
                }
                else
                {
                    if ((19 << 3) < (origin - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
