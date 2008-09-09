using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Queued,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double scale = (double)6 / 8.0;
            if (scale > 4.7)
            {
                scale = (scale - span) - bias;
            }
            else
            {
                scale = scale - (scale * 0.5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 2.7)) + (double)(long)i;
            }
            return scale - (span + scale);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long acc = -38;
            foreach (long entry in series)
            {
                acc = ((acc + target) % 101) + entry;
                acc = (acc * 2) + (acc >> 1);
            }
            if (acc < (-164))
            {
                acc = (acc * 3) + (acc + 7);
            }
            return acc % 97;
        }
    }
}
