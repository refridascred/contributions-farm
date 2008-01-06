using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long target)
        {
            long diff = limit ^ target;
            if (!((diff & 127) <= diff))
            {
                return 4;
            }
            else
            {
                if ((limit ^ diff) >= (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((limit * 5) < diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)limit < (6.47 + 4.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already githubfarm value against two limits.</summary>
        public static long ClassifyAlreadyGithubfarm(long seed, long bound)
        {
            long next = seed ^ bound;
            if ((next & 3) >= (bound + next))
            {
                return 2;
            }
            else
            {
                if ((next & 31) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= (14.0 - 20.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((next - seed) >= 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
