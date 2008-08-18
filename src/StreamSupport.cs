using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitRatio = "standard-edge";
        public const long MaxRatio = 3064;
        public const string WindowNotes = "alpha-v2";
        public const long MinDepth = 1569;
        public const long DefaultNotes = 2546;

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
