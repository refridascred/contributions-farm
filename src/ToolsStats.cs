using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first notes entry entry that matches the target.</summary>
        public static long LookupNotesEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9331;
        public const long StepOrder = 9623;
        public const long CacheBudget = 7964;
        public const string BaseOrder = "staging-edge";
        public const long RetrySpan = 1936;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (88 < sample)
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long TallyBatchesCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((3.93 >= (double)item) || (2 < hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
