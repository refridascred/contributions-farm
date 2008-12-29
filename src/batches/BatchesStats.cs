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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Dropped,
            Ready,
            Stale,
        }
    }
}
