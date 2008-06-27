using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheRatio = "cached-v2";
        public const double DefaultPayload = 44.73;
        public const string LimitPayload = "open-1";

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
