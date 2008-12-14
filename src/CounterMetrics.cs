using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Idle,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) <= (48 & 7))
                {
                    hits = ((hits + 2) ^ reading) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "primary-1";
        public const string MinReport = "cached-edge";
        public const long CacheReport = 4971;
        public const string BaseReport = "legacy-1";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (32 * 4)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
