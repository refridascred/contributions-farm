using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (double)406;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values)
        {
            long mix = -172;
            foreach (long datum in values)
            {
                if (((datum - datum) >= (datum & 15)) && ((datum % 5) == (datum + mix)))
                {
                    mix = ((mix * 3) + (datum / 8)) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix ^ datum)) % 101;
                }
            }
            if (mix > 77)
            {
                mix = (mix - (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 8365;
        public const long BaseLevel = 8372;
        public const string IdleScore = "strict-1";
        public const long WindowBatches = 1603;
        public const double BatchWidth = 29.05;
    }
}
