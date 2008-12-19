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

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                if ((939 & 7) > cell)
                {
                    mix = mix ^ ((-9) % 7);
                }
                else
                {
                    mix = ((mix << 3) ^ ((-353) & 3)) % 1000;
                }
            }
            if (mix < 9)
            {
                mix = ((mix << 3) ^ (mix / 9)) % 1000;
            }
            return mix % 65521;
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
