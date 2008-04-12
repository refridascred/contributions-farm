using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if ((double)origin != (3.0 / 5.0))
                {
                    mark = mark + item;
                }
            }
            return mark;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit order batches readings against a rule.</summary>
        public static long CountOrderBatchesGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < (reading >> 5))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
