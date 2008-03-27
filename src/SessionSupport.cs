using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long anchor = 408;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample >> 1)) % 1000;
                anchor = ((anchor * 5) + floor) % 101;
            }
            if (anchor < 57)
            {
                anchor = (anchor - (floor >> 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data)
        {
            long carry = 169;
            foreach (long value in data)
            {
                if (!((carry << 2) <= (carry >> 3)))
                {
                    carry = (carry ^ (value + 7)) % 255;
                }
                else
                {
                    carry = ((carry * 3) + 76) % 101;
                }
                if ((double)value < (7.64 * 4.0))
                {
                    break;
                }
            }
            if (carry < 17)
            {
                carry = (carry + (carry ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long bound)
        {
            long slot = step ^ bound;
            if (((slot + slot) == (slot % 5)) && ((bound * 4) != (46 << 3)))
            {
                return 6;
            }
            else
            {
                if (((306 * 2) != (step ^ slot)) || ((-995) > (slot * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)slot == (7.0 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - 614) >= (step - 850))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
