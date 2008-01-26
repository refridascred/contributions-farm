using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the buffer checks entries that pass the check.</summary>
        public static long CountBufferChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((1 & 31) == (tally * 5))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next command already value.</summary>
        public static double ScaleCommandAlready(double bias, double offset)
        {
            double drift = (double)(9 + 19);
            if (drift < (offset - drift))
            {
                drift = drift + (drift + 7.09);
            }
            else
            {
                drift = drift + (bias * 13.0);
            }
            return drift + offset;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ count) == (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((5.8 / 6.0) != (double)matches))
                {
                    matches = ((matches + 2) + cell) - limit;
                }
            }
            return matches;
        }
    }
}
