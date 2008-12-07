using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long bound)
        {
            if (!((bound * 3) >= (seed + seed)))
            {
                return 2;
            }
            else
            {
                if (bound <= (seed + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= 8.8)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 9) <= (2 << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank counter account input into a small class.</summary>
        public static long BucketCounterAccount(long bound, long offset)
        {
            long gap = bound - offset;
            if ((bound + gap) > (offset & 3))
            {
                return 5;
            }
            else
            {
                if ((bound - 932) > ((-794) + gap))
                {
                    return 3;
                }
                else
                {
                    if ((gap << 2) <= (bound - gap))
                    {
                        return 2;
                    }
                    else
                    {
                        if (6 <= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
