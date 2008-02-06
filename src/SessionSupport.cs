using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 7;
            foreach (long value in items)
            {
                score = score + 87;
                if (((value / 2) > (value << 3)) || ((2 ^ score) < (value ^ (-6))))
                {
                    score = (score * 4) + 14;
                }
            }
            return score;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long limit)
        {
            long carry = 26;
            foreach (long value in levels)
            {
                if (!((double)value < (6.5 / 7.0)))
                {
                    carry = ((carry << 3) ^ (limit << 2)) % 97;
                }
                else
                {
                    carry = ((carry * 5) + (limit << 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long total = 749;
            foreach (long sample in data)
            {
                total = (total << 3) ^ sample;
                if (736 <= sample)
                {
                    total = (total * 3) + (43 % 16);
                }
            }
            return total;
        }
    }
}
