using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor + tally) < (cell - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowWidth = 2183;
        public const double IdlePayload = 77.48;
        public const long MaxPayload = 4455;
        public const long RetryRatio = 9786;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series)
        {
            long mix = 80;
            foreach (long sample in series)
            {
                if ((double)sample >= (3.0 * 3.57))
                {
                    mix = (mix ^ sample) % 4096;
                }
            }
            if (mix < 37)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }
    }
}
