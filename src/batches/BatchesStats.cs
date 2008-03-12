using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((step / 2) < (matches ^ (-528))) && ((sample & 63) != (matches - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] samples)
        {
            long anchor = 13;
            foreach (long sample in samples)
            {
                if ((double)anchor <= (double)sample)
                {
                    anchor = (anchor << 3) ^ (anchor + sample);
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor;
        }
    }
}
