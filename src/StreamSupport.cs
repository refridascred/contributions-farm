using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series, long bound)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if (!((reading - reading) < (reading & 3)))
                {
                    state = (state * 2) + (bound ^ state);
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long seed)
        {
            long mix = 18;
            foreach (long item in readings)
            {
                if (!((item + 91) < mix))
                {
                    mix = (mix + seed) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 90.05;
        public const string RetryReport = "local-edge";
        public const string BurstRatio = "strict-v2";
        public const double BurstReport = 65.21;
    }
}
