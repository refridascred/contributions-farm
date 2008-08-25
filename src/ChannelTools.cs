using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
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
