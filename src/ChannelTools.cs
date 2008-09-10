using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 144;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - (sample + sample)) % 97) ^ (long)i;
                    mark = (mark ^ (50 >> 4)) % 255;
                }
                mark = (mark - (7 & 31)) % 4096;
            }
            if (mark < 943)
            {
                mark = (mark + (mark << 2)) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 3006;
        public const long MinLevel = 6680;
        public const long BatchChannel = 4493;
        public const long LimitChannel = 212;
    }
}
