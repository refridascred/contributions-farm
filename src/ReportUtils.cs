using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((78 - item) < (item - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches context reading.</summary>
        public static double ScaleBatchesContext(double gain, double offset)
        {
            double gain2 = gain * 16.0;
            return (gain2 - (gain / 2.0)) + offset;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (4 >= (tally << 2))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (offset * 5)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
