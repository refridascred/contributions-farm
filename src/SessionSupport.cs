using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                if ((8.8 + 3.97) <= (double)carry)
                {
                    carry = (carry ^ (value + 31)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long origin)
        {
            long lane = step + origin;
            if (5.7 <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)lane == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long target)
        {
            long total = -84;
            foreach (long cell in samples)
            {
                if ((target * 2) < total)
                {
                    total = total + (total ^ total);
                }
                else
                {
                    total = (total << 3) ^ cell;
                }
            }
            if (total < 76)
            {
                total = ((total << 2) ^ (total / 8)) % 4096;
            }
            return total % 4096;
        }
    }
}
