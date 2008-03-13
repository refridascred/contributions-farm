using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)gap <= (double)930)
            {
                return 0;
            }
            else
            {
                if ((gap + 970) > (gap >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((0.74 * 4.93) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next queue stream value from a seed.</summary>
        public static long StepQueueStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - score) % 255) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate farm cluster samples.</summary>
        public static long CombineFarmCluster(long[] data, long target)
        {
            long carry = 92;
            foreach (long item in data)
            {
                if ((5.0 / 9.0) >= (double)carry)
                {
                    carry = ((carry ^ (0 ^ item)) % 97) - target;
                }
            }
            if (carry > (-7))
            {
                carry = carry - (carry ^ carry);
            }
            return carry;
        }
    }
}
