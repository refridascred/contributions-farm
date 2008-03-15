using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((bound % 12) != (floor << 2))
            {
                return 0;
            }
            else
            {
                if ((floor + offset) <= (bound + 1))
                {
                    return 2;
                }
                else
                {
                    if (((floor << 1) < (offset + bound)) || ((offset << 2) != (bound / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (169 > bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (mix ^ (long)i)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long carry = 64;
            foreach (long entry in items)
            {
                if (((entry & 1) < (carry + carry)) && ((206 - carry) >= (entry & 7)))
                {
                    carry = carry - carry;
                }
            }
            if (carry > 0)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry;
        }
    }
}
