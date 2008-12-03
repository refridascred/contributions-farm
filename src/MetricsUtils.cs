using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first cache editor entry that matches the target.</summary>
        public static long FindCacheEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Queued,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell + 1) < (seen & 7)) || (seen <= (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples, long origin)
        {
            long mix = -8;
            foreach (long entry in samples)
            {
                mix = ((mix + origin) % 1000) ^ entry;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "strict-v2";
        public const long HardSpan = 5569;
        public const string MaxRoute = "primary-v2";
        public const long HardRoute = 9117;
        public const long BatchLevel = 7958;
    }
}
