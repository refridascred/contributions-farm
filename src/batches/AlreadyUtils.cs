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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long origin, long step)
        {
            long offset = origin + step;
            if ((39 >> 1) > (step + offset))
            {
                return 0;
            }
            else
            {
                if ((offset - 689) <= (366 >> 3))
                {
                    return 8;
                }
                else
                {
                    if (((step - 62) < (step - 9)) && (origin >= (offset + 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 7154;
        public const long BatchDepth = 7482;
        public const long BaseEntry = 2768;

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
