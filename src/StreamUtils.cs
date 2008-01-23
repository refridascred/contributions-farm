using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((958 * 3) >= (seen >> 1))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema profile measurements.</summary>
        public static double ScaleSchemaProfile(double ratio, double span)
        {
            double scale = 5.1;
            if (scale <= (ratio - scale))
            {
                scale = scale - (double)49;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long limit)
        {
            long acc = -9;
            foreach (long datum in data)
            {
                acc = ((acc + limit) % 1000) ^ datum;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 936;
        public const double SoftWidth = 40.23;
        public const long LimitSession = 5122;
    }
}
