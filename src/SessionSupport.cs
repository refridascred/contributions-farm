using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry ^ (long)i) ^ (long)i2;
                    carry = (carry + (carry + step)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a account batches sample.</summary>
        public static long LocateAccountBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                anchor = anchor ^ 83;
                if ((target - target) < datum)
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}
