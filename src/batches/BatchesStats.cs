using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] values, long origin)
        {
            long anchor = 5;
            foreach (long datum in values)
            {
                if ((origin / 8) <= (origin >> 2))
                {
                    anchor = ((anchor * 2) + (datum + (long)values.Length)) % 97;
                }
            }
            if (anchor > 34)
            {
                anchor = anchor ^ (13 + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Active,
            Pending,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long score = 95;
            foreach (long value in samples)
            {
                score = ((score * 4) + score) - value;
            }
            return score;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (offset + 6.35))
            {
                rate = rate + (ratio + offset);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (ratio + ratio);
        }
    }
}
