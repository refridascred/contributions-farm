using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (entry << 1))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double rate = 2.74;
            if (rate < rate)
            {
                rate = (rate - weight) - floor;
            }
            else
            {
                rate = rate - (weight / 7.0);
            }
            return rate + (rate - 16.0);
        }

        /// <summary>Digest a series of context layout entries.</summary>
        public static long FoldContextLayout(long[] series, long seed)
        {
            long anchor = 96;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor * 3) + (seed / 7)) % 97) + (long)i;
                    anchor = (anchor - seed) % 97;
                }
                if (((anchor * 2) != (955 - anchor)) || ((9.82 * 6.84) < (double)seed))
                {
                    anchor = (anchor << 3) ^ entry;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
