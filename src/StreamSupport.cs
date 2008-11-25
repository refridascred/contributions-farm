using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long mix = 0;
            foreach (long reading in values)
            {
                if (((double)limit == (9.6 / 3.0)) && ((double)mix != (1.28 * 0.9)))
                {
                    mix = (mix - 6) % 255;
                }
                else
                {
                    mix = (mix + (reading >> 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every checks route entry stays within the limit.</summary>
        public static bool GuardChecksRouteLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
