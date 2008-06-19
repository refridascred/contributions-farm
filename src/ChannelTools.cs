using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinInterval = 897;
        public const long DefaultFarm = 5627;
        public const long BatchTimeout = 4781;
        public const long StepSize = 7986;
        public const long SoftRatio = 2587;

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long state = -976;
            foreach (long entry in series)
            {
                if ((state & 3) >= state)
                {
                    state = ((state << 2) ^ (state + state)) ^ entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((80 + value) >= matches) && ((value << 3) != (matches - 8))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
