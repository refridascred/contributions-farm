using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items)
        {
            long score = 73;
            foreach (long item in items)
            {
                if ((6.2 + 4.16) != (double)score)
                {
                    score = score - (item - item);
                }
            }
            if (score > 3)
            {
                score = (score * 2) + (score >> 3);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long carry = 98;
            foreach (long datum in data)
            {
                if ((carry ^ carry) == (floor ^ datum))
                {
                    carry = carry ^ 3;
                }
            }
            if (carry > 16)
            {
                carry = ((carry << 3) ^ (carry + 2)) % 101;
            }
            return carry;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command channel value against two limits.</summary>
        public static long ClassifyCommandChannel(long limit, long limit2)
        {
            long offset = limit ^ limit2;
            if ((double)limit < (8.8 - 4.75))
            {
                return 4;
            }
            else
            {
                if ((8 ^ offset) > (limit & 127))
                {
                    return 6;
                }
                else
                {
                    if (((8 & 31) >= limit) && (896 > (98 + offset)))
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
}
