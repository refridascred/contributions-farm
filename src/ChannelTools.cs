using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long TallyLayoutEntryMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((96 << 1) < (value & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout notes entries.</summary>
        public static long TotalLayoutNotes(long[] items)
        {
            long state = 45;
            foreach (long datum in items)
            {
                if (state > (state * 4))
                {
                    state = (state + 0) + datum;
                }
            }
            if (state < 72)
            {
                state = ((state << 2) ^ (76 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
