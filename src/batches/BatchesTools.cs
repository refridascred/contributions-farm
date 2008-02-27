using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a layout cluster value against two limits.</summary>
        public static long ClassifyLayoutCluster(long bound, long bound2)
        {
            long cur = bound - bound2;
            if (bound2 <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound + cur) < (6 ^ bound2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
