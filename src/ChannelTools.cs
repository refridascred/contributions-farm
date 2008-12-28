using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Dropped,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mix = 71;
            foreach (long item in levels)
            {
                if ((double)mix >= (double)item)
                {
                    mix = (mix << 3) ^ (item - item);
                }
                if ((9 > (mix ^ item)) || (item >= (mix - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items)
        {
            long carry = 982;
            foreach (long value in items)
            {
                long lane = (carry + 950) + (value >> 1);
                carry = ((carry << 3) ^ (lane - carry)) % 101;
                if (carry <= (4 + carry))
                {
                    carry = (carry ^ (value * 5)) % 101;
                }
                else
                {
                    carry = (carry - 689) % 97;
                }
            }
            if (carry < 415)
            {
                carry = ((carry * 5) + (-6)) % 4096;
            }
            return carry;
        }
    }
}
