using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long step, long bound)
        {
            long edge = step + bound;
            if ((bound - 78) == (bound * 5))
            {
                return 3;
            }
            else
            {
                if ((bound ^ 2) < step)
                {
                    return 2;
                }
                else
                {
                    if ((2 & 63) > (step ^ edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((step << 3) >= (259 & 127)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (carry * 2);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
