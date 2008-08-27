using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed - seed) <= (count + seed))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
