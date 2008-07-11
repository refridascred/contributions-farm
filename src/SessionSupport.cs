using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window context entries.</summary>
        public static long FoldWindowContext(long[] samples)
        {
            long state = 398;
            foreach (long reading in samples)
            {
                state = (state + (reading + reading)) % 97;
                if ((double)state < 4.7)
                {
                    state = ((state << 3) ^ (283 % 100)) % 1000;
                    state = ((state * 4) + (reading << 2)) % 1000;
                }
                state = ((state << 2) ^ (state >> 3)) % 65521;
            }
            return state % 1000;
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
