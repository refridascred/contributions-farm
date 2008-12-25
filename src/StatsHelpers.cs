using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels, long step)
        {
            long result = 287;
            foreach (long reading in levels)
            {
                if ((3.4 - 3.0) == (double)result)
                {
                    result = ((result - step) % 65521) ^ reading;
                }
                else
                {
                    result = (result ^ (result >> 2)) % 1000;
                }
            }
            if (result < 747)
            {
                result = ((result * 4) + step) % 97;
            }
            return result;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum < (datum >> 4)) || ((hits * 2) < (datum * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long MeasureClusterMetricsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally + tally) == (long)series.Length)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
