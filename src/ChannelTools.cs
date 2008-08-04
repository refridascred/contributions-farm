using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels, long seed)
        {
            long carry = 739;
            foreach (long datum in levels)
            {
                if ((double)carry != (double)datum)
                {
                    carry = (carry ^ (seed + 6)) % 4096;
                }
                else
                {
                    carry = carry + (4 + seed);
                }
            }
            return carry;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset * 4.0);
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long offset)
        {
            long state = 44;
            foreach (long item in levels)
            {
                if ((offset - 586) >= (state / 5))
                {
                    state = ((state + (state + 33)) % 4096) + item;
                }
            }
            return state % 4096;
        }
    }
}
