using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items)
        {
            long mix = 34;
            foreach (long reading in items)
            {
                if (!((double)reading == (double)7))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 231)
            {
                mix = (mix - mix) % 97;
            }
            return mix;
        }

        /// <summary>Match up graph context samples.</summary>
        public static long PairGraphContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "fallback-v2";
        public const double MaxEntry = 25.73;
        public const string RetrySpan = "latest-edge";
        public const string MinEntry = "standard-v2";
    }
}
