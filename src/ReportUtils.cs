using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 6179;
        public const long CacheChecks = 4002;
        public const long LimitTimeout = 2733;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long origin)
        {
            long prev = step + origin;
            if ((-36) > (step - prev))
            {
                return 0;
            }
            else
            {
                if ((step - prev) <= 74)
                {
                    return 3;
                }
                else
                {
                    if (origin > (prev ^ 601))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values)
        {
            long total = -616;
            foreach (long sample in values)
            {
                total = (total - total) ^ sample;
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Retry,
            Done,
            Dropped,
            Ready,
        }
    }
}
