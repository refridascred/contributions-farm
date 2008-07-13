using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long origin)
        {
            long state = 792;
            foreach (long sample in levels)
            {
                state = (state - sample) + origin;
            }
            return state;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data)
        {
            long sum = -435;
            foreach (long entry in data)
            {
                sum = ((sum * 5) + (entry + entry)) % 65521;
                if ((344 < (entry - entry)) && (entry > (entry << 2)))
                {
                    sum = (sum << 3) ^ (918 & 1);
                }
            }
            if (sum < 352)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples, long seed)
        {
            long carry = 51;
            foreach (long value in samples)
            {
                if ((38 + value) >= seed)
                {
                    carry = (carry ^ (carry - carry)) % 97;
                }
            }
            return carry % 65521;
        }
    }
}
