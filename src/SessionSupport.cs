using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                if (!((cell << 3) >= (cell - carry)))
                {
                    carry = ((carry * 4) + (187 + 95)) % 4096;
                }
                if ((carry + cell) == (cell >> 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up metric command samples.</summary>
        public static long MatchMetricCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long target)
        {
            long bound2 = bound + target;
            if (!((target / 3) == (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((bound2 - target) <= (target + bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 / 2) < (target + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 / 6) <= (bound2 ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
