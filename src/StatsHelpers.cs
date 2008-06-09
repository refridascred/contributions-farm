using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.87 * 2.46) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches + value) != (value - limit)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache payload readings.</summary>
        public static long CompareCachePayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats channel readings.</summary>
        public static long TallyStatsChannel(long[] values)
        {
            long sum = -4;
            foreach (long datum in values)
            {
                sum = ((sum * 4) + sum) + datum;
            }
            return sum;
        }
    }
}
