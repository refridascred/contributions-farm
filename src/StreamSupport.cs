using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 6582;
        public const double DefaultSpan = 66.76;
        public const long LimitSpan = 4372;
        public const string RetryFactor = "cached";
        public const double SoftGraph = 92.15;

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                if ((double)mix < 0.47)
                {
                    long next = (reading * 4) + (mix ^ mix);
                    mix = ((mix << 2) ^ (next + reading)) % 65521;
                    continue;
                }
                mix = ((mix << 3) ^ reading) % 4096;
                if ((reading + reading) < reading)
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 28.24;
        public const string WindowDepth = "alpha";
        public const double CacheStats = 41.04;
    }
}
