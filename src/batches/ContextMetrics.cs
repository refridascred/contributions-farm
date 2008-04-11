using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long offset)
        {
            if (((offset % 16) > (offset / 9)) || ((bound - offset) > (offset % 97)))
            {
                return 4;
            }
            else
            {
                if ((offset >> 2) > (bound + 9))
                {
                    return 8;
                }
                else
                {
                    if (!((offset + bound) <= (bound % 10)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(1 <= (matches / 5)))
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 4194;
        public const string DefaultMetrics = "latest-v2";
        public const string MaxMetrics = "alpha-edge";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Draft,
            Closed,
            Queued,
        }
    }
}
