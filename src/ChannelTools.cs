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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen % 97) >= (item & 31)) && ((992 < (item << 2)) && ((double)seen >= (double)item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
