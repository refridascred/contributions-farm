using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a cache record counter forward.</summary>
        public static long IterateCacheRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix * 5) + 6;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = mix ^ (sample + 7);
            }
            if (mix < 52)
            {
                mix = (mix ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 7153;
        public const long MinMetric = 4065;
        public const string IdleMetric = "strict-edge";
        public const string WindowMetric = "open-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleTimeout = 21.33;
        public const long BurstLayout = 9290;
        public const string HardDepth = "latest";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!!(((long)i << 1) < (long)i))
                {
                    sum = ((sum << 2) ^ ((long)i - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
