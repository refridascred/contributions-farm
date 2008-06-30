using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell & 63) < tally) || (8.99 > (double)tally))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next route entry value from a seed.</summary>
        public static long SeriesRouteEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
