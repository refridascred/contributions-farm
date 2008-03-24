using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels)
        {
            long mark = 36;
            foreach (long value in levels)
            {
                mark = (mark + (value - mark)) % 101;
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((bound * 2) >= (entry << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the profile entry entries that pass the check.</summary>
        public static long AuditProfileEntryOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3.4 / 8.0) <= (double)floor)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
