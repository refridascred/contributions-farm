using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double scale2 = offset / 7.0;
            if (scale2 <= offset)
            {
                scale2 = scale2 + (double)656;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Done,
            Retry,
            Active,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (5.66 + 4.5))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }
    }
}
