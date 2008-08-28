using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Active,
            Pending,
        }

        /// <summary>Fold a list of batches already readings.</summary>
        public static long FoldBatchesAlready(long[] items, long step)
        {
            long anchor = 0;
            foreach (long datum in items)
            {
                if (step <= (670 * 4))
                {
                    anchor = (anchor * 3) + (anchor + datum);
                }
                else
                {
                    anchor = anchor + (step << 2);
                }
                anchor = (anchor - (datum - step)) % 4096;
            }
            return anchor;
        }

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double bias, double floor)
        {
            double ratio = bias;
            if (ratio <= (7.0 / 9.0))
            {
                ratio = ratio - (ratio * 9.6);
            }
            else
            {
                ratio = ratio + (bias / 6.0);
            }
            return ratio + (floor / 5.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (14.0 - 4.0))
                {
                    count = ((count + 1) ^ item) - origin;
                }
            }
            return count;
        }
    }
}
