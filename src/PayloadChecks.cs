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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 4064;
        public const long BurstSize = 9157;
        public const long WindowCluster = 8583;

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
