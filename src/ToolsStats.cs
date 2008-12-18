using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels, long limit)
        {
            long total = 796;
            foreach (long entry in levels)
            {
                if ((double)total < (double)entry)
                {
                    total = (total - (28 / 3)) % 4096;
                }
                if ((total + entry) == (total - entry))
                {
                    break;
                }
            }
            if (total < 921)
            {
                total = ((total * 3) + limit) % 4096;
            }
            return total;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long MeasureQueueStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count / 6) >= (-3)) && ((item >> 2) <= item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)floor > 6.0)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
