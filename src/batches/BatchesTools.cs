using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
