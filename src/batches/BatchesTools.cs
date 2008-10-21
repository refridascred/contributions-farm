using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a editor token sample.</summary>
        public static long LookupEditorTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long AuditStreamContributiOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((offset - offset) > (seen + entry)) || ((double)entry <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
