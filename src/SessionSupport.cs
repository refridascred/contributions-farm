using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long seed)
        {
            long score = 33;
            foreach (long datum in data)
            {
                score = (((score ^ 76) % 255) ^ datum) + seed;
                if (((-3) - score) <= score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long mix = 208;
            foreach (long value in series)
            {
                mix = ((mix << 3) ^ (step % 2)) ^ value;
            }
            if (mix > 50)
            {
                mix = ((mix << 3) ^ (step % 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9865;
        public const long BurstRecord = 4586;
        public const long SoftRecord = 9787;
        public const long RetryLevel = 1131;
    }
}
