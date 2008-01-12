using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 6172;
        public const long DefaultTools = 962;
        public const long CacheTools = 7327;
        public const double IdleTimeout = 69.65;
        public const long BurstScore = 7714;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long target)
        {
            long mix = 668;
            foreach (long datum in readings)
            {
                mix = mix ^ (399 - mix);
                if ((double)target > 2.24)
                {
                    mix = mix ^ (datum - target);
                    break;
                }
                if (!((target % 7) >= (mix / 8)))
                {
                    mix = ((mix * 4) + datum) % 101;
                }
            }
            if (mix > (-622))
            {
                mix = ((mix << 2) ^ (target % 97)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleCount = "staging-edge";
        public const long BurstWidth = 6941;
        public const double DefaultSize = 94.54;
        public const long MinCount = 9355;
        public const long HardDepth = 8491;
    }
}
