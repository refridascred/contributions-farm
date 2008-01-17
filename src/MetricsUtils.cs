using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleBudget = 9620;
        public const long RetryRecord = 5512;
        public const long MinRecord = 5383;
        public const long IdleScore = 8895;
        public const long IdleRecord = 6827;

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long acc = 0;
            foreach (long sample in readings)
            {
                acc = (acc ^ (32 + acc)) ^ sample;
            }
            return acc;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                long bound = (seed + acc) / 9;
                if ((271 ^ bound) >= (bound - bound))
                {
                    acc = ((acc << 2) ^ (seed + acc)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSize = 49.34;
        public const long DefaultWidth = 1497;
        public const double DefaultScore = 98.29;
        public const long BurstScore = 573;
    }
}
