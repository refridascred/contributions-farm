using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseScore = 431;
        public const long IdleProfile = 5975;
        public const long BatchDepth = 9407;
        public const long LimitSpan = 750;
        public const long LimitProfile = 8605;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "latest";
        public const long StepBuffer = 8361;
        public const double BaseBuffer = 56.37;
        public const long MaxBuffer = 7145;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool CheckRecordCommitsBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long offset)
        {
            if ((double)target >= (16.0 - 1.9))
            {
                return 4;
            }
            else
            {
                if (offset >= (offset + target))
                {
                    return 3;
                }
                else
                {
                    if ((3.63 * 9.1) >= (13.0 - 3.93))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target ^ 1) <= (277 + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = carry + (limit % 97);
                if (!((carry + carry) < (limit << 3)))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ carry) % 65521;
                    carry = carry ^ ((long)i + 39);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
