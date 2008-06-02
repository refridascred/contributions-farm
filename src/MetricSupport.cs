using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseFactor = "strict-v2";
        public const long MinCluster = 5474;
        public const long LimitCluster = 2133;
        public const long BaseScore = 6539;
        public const long LimitDepth = 214;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                mark = ((mark + (975 & 7)) % 97) ^ reading;
            }
            return mark % 4096;
        }
    }
}
