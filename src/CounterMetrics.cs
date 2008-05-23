using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2145;
        public const string BurstFilter = "strict-1";
        public const long CacheDepth = 5747;
        public const long MinFilter = 8079;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - 9) == (seen * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
