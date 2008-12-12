using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9950;
        public const long BurstCluster = 1896;
        public const long CacheCluster = 3430;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((-14) - count) >= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Queued,
            Ready,
            Done,
        }
    }
}
