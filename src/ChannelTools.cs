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

        /// <summary>Iterate the format filter series from a seed.</summary>
        public static long DeriveFormatFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(((-63) + floor) > (sum & 63)))
                {
                    continue;
                }
                sum = sum - (sum << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
