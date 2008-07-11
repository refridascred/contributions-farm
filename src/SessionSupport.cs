using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long seed)
        {
            if ((target >> 4) < seed)
            {
                return 8;
            }
            else
            {
                if (((target + seed) >= target) && (target < seed))
                {
                    return 6;
                }
                else
                {
                    if ((0.65 - 9.2) > (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - target) == (seed - 698))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (origin > result)
                {
                    result = (result ^ 5) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
