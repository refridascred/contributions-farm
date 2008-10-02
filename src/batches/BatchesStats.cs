using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (double)81) + (double)(long)i) + offset;
            }
            return bias + (weight / 8.0);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (16.0 < (double)tally)
                {
                    tally = ((tally + 2) - datum) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally / 7) < (datum & 31))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
