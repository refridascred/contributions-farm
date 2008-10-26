using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (3.42 / 6.0))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit notes account readings against a rule.</summary>
        public static long AuditNotesAccountGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((1.5 > (double)(long)items.Length) || (limit > (2 - count)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 > 8.0)
            {
                bias3 = bias3 - (5.1 - bias);
            }
            return bias3 - bias2;
        }
    }
}
