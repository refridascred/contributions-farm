using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long seed)
        {
            long anchor = -78;
            foreach (long entry in samples)
            {
                if ((seed >> 4) <= seed)
                {
                    anchor = ((anchor * 3) + (3 >> 4)) ^ entry;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 8) % 1000;
                }
            }
            if (anchor < 631)
            {
                anchor = ((anchor * 4) + 9) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Ready,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Accumulate notes stream samples.</summary>
        public static long CombineNotesStream(long[] readings, long offset)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total - (item ^ item)) % 4096) - offset;
            }
            return total % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
