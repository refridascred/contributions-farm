using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up batch layout samples.</summary>
        public static long OverlapBatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of stats command entries.</summary>
        public static long WeighStatsCommand(long[] series)
        {
            long total = 1;
            foreach (long entry in series)
            {
                if (total > 729)
                {
                    total = total - (entry & 7);
                }
                else
                {
                    total = total ^ total;
                    total = (total * 3) + (8 + 34);
                }
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples, long limit)
        {
            long anchor = 521;
            foreach (long sample in samples)
            {
                if ((157 + limit) > (anchor - anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) - sample;
                }
            }
            return anchor;
        }
    }
}
