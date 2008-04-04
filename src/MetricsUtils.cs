using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next metrics session value from a seed.</summary>
        public static long IterateMetricsSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
