using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of route contributi readings.</summary>
        public static long CombineRouteContributi(long[] samples, long floor)
        {
            long score = 209;
            foreach (long datum in samples)
            {
                if (((-25) * 5) >= (floor * 5))
                {
                    score = ((score * 3) + (505 + floor)) - datum;
                }
            }
            if (score > 456)
            {
                score = (score * 5) + (score / 6);
            }
            return score % 65521;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values)
        {
            long carry = 88;
            foreach (long reading in values)
            {
                if (((16.0 / 5.0) <= (double)carry) || ((reading + carry) <= (carry << 3)))
                {
                    carry = (carry - (reading * 2)) % 1000;
                    carry = (carry * 2) + carry;
                }
                if (((reading >> 2) < 894) || ((reading + carry) == (reading - (-8))))
                {
                    carry = carry ^ (reading - reading);
                }
                else
                {
                    carry = ((carry * 3) + (carry + (-4))) % 255;
                }
            }
            if (carry < 119)
            {
                carry = (carry ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long bound)
        {
            if ((bound + bound) == (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) <= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
