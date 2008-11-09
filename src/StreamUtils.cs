using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
        public const long MinCount = 8047;
        public const long HardMetric = 2681;
        public const long SoftMetric = 416;

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
