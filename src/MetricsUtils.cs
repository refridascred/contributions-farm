using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Closed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank buffer editor input into a small class.</summary>
        public static long BucketBufferEditor(long offset, long limit)
        {
            if (((offset % 60) == (offset + offset)) && ((offset + offset) <= (offset * 5)))
            {
                return 3;
            }
            else
            {
                if (limit < (limit / 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSize = 6847;
        public const long MinChannel = 8310;
        public const long IdleRatio = 1762;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Queued,
            Draft,
            Failed,
            Locked,
        }
    }
}
