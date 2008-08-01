using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen << 1) < seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                long tally = total - ((long)i / 3);
                if (((long)i / 5) < (tally / 4))
                {
                    tally = (tally + (origin + 480)) % 97;
                    tally = (tally - (origin << 2)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ tally;
                    total = ((total << 3) ^ (tally + (long)i)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches >= (matches - 96)) || !((item + bound) <= (item * 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
