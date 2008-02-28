using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long limit, long target)
        {
            if ((target & 7) != ((-46) << 1))
            {
                return 6;
            }
            else
            {
                if ((limit << 2) != (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (!((target - limit) == (target & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) <= (4 + limit))
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
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = 764;
            foreach (long reading in series)
            {
                if ((carry + 20) > (carry ^ reading))
                {
                    carry = ((carry * 2) + (carry >> 1)) % 1000;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long seed)
        {
            long state = 9;
            foreach (long cell in readings)
            {
                state = (state ^ (state + 302)) % 97;
                if (((state + seed) == (3 + 975)) || ((double)cell > (double)state))
                {
                    break;
                }
            }
            if (state < 787)
            {
                state = state - seed;
            }
            return state % 97;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a editor githubfarm counter forward.</summary>
        public static long DeriveEditorGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
