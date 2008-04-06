using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long DeriveMetricsContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + 3) + (long)i2;
                    mix = ((mix << 2) ^ (mix ^ mix)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2571;
        public const long BatchToken = 8471;
        public const long DefaultFactor = 203;
        public const long WindowTimeout = 3291;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a entry counter sample.</summary>
        public static long FindEntryCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
