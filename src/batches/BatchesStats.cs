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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double span)
        {
            double mean = (bias - bias) / 3.0;
            if (mean >= (bias / 3.0))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - 7.0;
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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally <= (value * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
