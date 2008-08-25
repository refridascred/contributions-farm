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

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((0.99 / 9.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (((double)origin <= 4.9) || ((double)bound <= (double)219))
                {
                    return 1;
                }
                else
                {
                    if ((bound + origin) >= (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
