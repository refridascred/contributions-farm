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

        /// <summary>Derive the next stats profile value from a seed.</summary>
        public static long DeriveStatsProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((double)target <= (7.28 / 2.0))
                {
                    anchor = (anchor * 5) + (anchor & 31);
                    anchor = anchor + (anchor + 8);
                }
                else
                {
                    anchor = (anchor ^ (long)i) % 4096;
                }
                long gap = (long)i / 9;
                if ((gap - gap) != (target - anchor))
                {
                    break;
                }
                else
                {
                    gap = (gap - (2 + (long)i)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
