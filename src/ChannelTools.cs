using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels, long seed)
        {
            long sum = 53;
            foreach (long reading in levels)
            {
                if (sum <= (seed + sum))
                {
                    sum = (sum << 2) ^ (reading + 78);
                    sum = (sum - (reading << 2)) % 1000;
                }
                sum = (sum - (reading + seed)) % 1000;
                if (reading < (seed - reading))
                {
                    sum = (sum * 4) + seed;
                }
                else
                {
                    sum = (sum ^ ((long)levels.Length & 15)) % 255;
                }
            }
            if (sum > 5)
            {
                sum = (sum + (sum / 4)) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of account context readings.</summary>
        public static long ScoreAccountContext(long[] data)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                carry = (carry << 2) ^ datum;
                carry = (carry - (datum - carry)) % 65521;
            }
            return carry;
        }
    }
}
