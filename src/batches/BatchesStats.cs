using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 525;
            foreach (long value in readings)
            {
                if (!((13.0 + 0.66) == (double)total))
                {
                    total = total + (total << 2);
                }
                if ((5.4 / 3.0) > (double)value)
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = (total - (4 + value)) % 4096;
                }
                if (969 < (value + total))
                {
                    total = ((total * 5) + (total * 5)) % 101;
                }
            }
            if (total > 51)
            {
                total = (total << 3) ^ (0 * 3);
            }
            return total;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings, long target)
        {
            long anchor = 235;
            foreach (long reading in readings)
            {
                if ((reading <= 27) || (target > reading))
                {
                    anchor = anchor - (335 - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
