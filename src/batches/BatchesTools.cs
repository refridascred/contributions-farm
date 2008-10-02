using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Pending,
            Dropped,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double scale = 9.0;
            if (scale > (scale + rate))
            {
                scale = (scale + 4.3) - bias;
            }
            return scale + (rate * 1.0);
        }

        /// <summary>Audit support notes readings against a rule.</summary>
        public static long AuditSupportNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 7) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
