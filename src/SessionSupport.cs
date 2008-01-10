using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 4213;
        public const long RetryRecord = 8085;
        public const long RetrySize = 2516;
        public const double BaseRecord = 26.11;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long origin)
        {
            long mix = -74;
            foreach (long sample in samples)
            {
                if ((6 >> 3) < (sample / 7))
                {
                    mix = ((mix << 3) ^ origin) % 65521;
                }
            }
            if (mix < 52)
            {
                mix = ((mix * 3) + (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
