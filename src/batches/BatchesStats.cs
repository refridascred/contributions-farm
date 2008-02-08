using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((8 / 2) <= hits)
                {
                    hits = ((hits + 2) ^ sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue cache entries.</summary>
        public static long TotalQueueCache(long[] series)
        {
            long acc = 36;
            foreach (long cell in series)
            {
                acc = ((acc << 3) ^ (23 - acc)) % 97;
                if (cell > (cell ^ cell))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }
    }
}
