using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((752 % 12) < (datum + datum))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
