using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((58 - hits) < entry) || ((hits << 1) <= (hits & 63)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
