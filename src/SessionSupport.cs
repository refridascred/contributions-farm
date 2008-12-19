using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long limit)
        {
            long edge = origin + limit;
            if ((origin * 3) == (limit - 38))
            {
                return 5;
            }
            else
            {
                if ((limit < (edge * 4)) || ((8.2 - 17.0) != (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)edge > (10.0 - 9.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long carry = -92;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + 735) ^ (long)i) ^ sample;
                }
                if (16.0 > (double)carry)
                {
                    carry = carry ^ (carry + (long)items.Length);
                }
            }
            if (carry < 8)
            {
                carry = (carry * 4) + (carry << 1);
            }
            return carry;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                if ((12.0 - 4.0) != (double)bound)
                {
                    sum = ((sum * 3) + sum) ^ cell;
                }
            }
            if (sum > 7)
            {
                sum = sum + 67;
            }
            return sum % 1000;
        }
    }
}
