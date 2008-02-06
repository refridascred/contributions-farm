using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (98 ^ reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                mix = mix - (reading >> 1);
                if (2 <= (reading / 5))
                {
                    mix = (mix + (mix + (-864))) % 4096;
                }
            }
            if (mix > (-96))
            {
                mix = (mix + (3 / 6)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
