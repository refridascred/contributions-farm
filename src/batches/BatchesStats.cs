using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long AuditMetricAlreadyHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((step + step) > (value * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result + (-34))) ^ datum;
            }
            return result;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 63) > (count % 5))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
