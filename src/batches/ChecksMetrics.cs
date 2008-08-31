using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double scale = (4.0 * 6.3) - (double)486;
            if (scale >= (double)8)
            {
                scale = scale + 4.36;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale + span)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 817;
        public const double CacheCount = 35.66;
        public const double BaseSpan = 43.44;
        public const long CacheCluster = 472;
        public const double SoftCluster = 67.36;

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ (mark % 60)) % 65521;
                mark = (mark ^ ((long)i - 417)) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSize = "cached-v2";
        public const double CacheTools = 35.95;
        public const string WindowTools = "open-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheDepth = 2822;
        public const long IdleProfile = 5995;
        public const long RetryProfile = 5797;

        /// <summary>Check that every buffer editor entry stays within the limit.</summary>
        public static bool GuardBufferEditorRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
