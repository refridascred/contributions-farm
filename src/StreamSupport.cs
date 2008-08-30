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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)delta <= (double)floor) || ((577 >> 4) <= (limit / 4)))
            {
                return 5;
            }
            else
            {
                if ((delta * 5) < (delta * 4))
                {
                    return 3;
                }
                else
                {
                    if ((59 + limit) > (limit & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 5) <= (floor ^ limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
