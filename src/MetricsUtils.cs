using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool ValidateLayoutSchemaRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of farm command readings.</summary>
        public static long FoldFarmCommand(long[] samples, long target)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                mix = (((mix << 3) ^ (entry * 5)) % 4096) - target;
            }
            return mix % 97;
        }
    }
}
