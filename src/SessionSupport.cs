using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 150;
        public const string BurstDepth = "alpha-1";
        public const string LimitFarm = "stable-v2";
        public const long CacheFarm = 8408;

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
