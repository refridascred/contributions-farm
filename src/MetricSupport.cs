using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 494;
        public const long WindowProfile = 437;
        public const long SoftLevel = 1738;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading << 2) > (reading + 884))
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

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
