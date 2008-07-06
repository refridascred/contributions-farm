using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) == (matches << 1))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                if (!((sample - sample) <= (anchor % 97)))
                {
                    anchor = (anchor ^ (sample + 48)) % 255;
                }
                if (((-470) >= (4 + sample)) && ((sample ^ sample) == (92 >> 5)))
                {
                    anchor = (anchor + (anchor ^ sample)) % 65521;
                }
                else
                {
                    anchor = (anchor + (sample ^ anchor)) % 65521;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor >> 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2211;
        public const long LimitAlready = 2185;
        public const double HardDepth = 33.56;
        public const long BurstAlready = 5340;
    }
}
