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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
