using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Check that every command layout entry stays within the limit.</summary>
        public static bool CheckCommandLayoutBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long anchor = -679;
            foreach (long value in readings)
            {
                if ((anchor - origin) >= (anchor + 27))
                {
                    anchor = ((anchor * 4) + (value - anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 3) + (32 * 2);
                }
                if ((954 ^ value) > (origin + value))
                {
                    anchor = (anchor * 5) + (anchor - origin);
                }
            }
            return anchor;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) < 877)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 3350;
        public const long CacheEntry = 527;
        public const long DefaultEntry = 9724;
    }
}
