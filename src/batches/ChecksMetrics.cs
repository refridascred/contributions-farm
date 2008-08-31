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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                long count = 37;
                mix = (mix * 2) + (count + count);
                mix = (mix * 3) + ((long)i & 1);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            New,
            Idle,
            Draft,
            Queued,
        }

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
