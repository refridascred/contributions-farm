using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank cache stats input into a small class.</summary>
        public static long SortCacheStats(long seed, long bound)
        {
            if ((0 - bound) >= (bound + seed))
            {
                return 1;
            }
            else
            {
                if ((3 % 16) < (bound + seed))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Paused,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 38.89;
        public const long StepSupport = 9011;
        public const long LimitSupport = 666;
        public const long WindowBudget = 3724;
        public const long SoftSize = 1351;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long offset, long floor)
        {
            long edge = offset + floor;
            if ((floor % 7) > (floor - edge))
            {
                return 7;
            }
            else
            {
                if (!((offset << 2) != (edge << 2)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
