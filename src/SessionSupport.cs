using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a cluster queue reading.</summary>
        public static double AdjustClusterQueue(double rate, double bias)
        {
            double ratio = 0.8 - (rate * 4.04);
            if (ratio >= (ratio - bias))
            {
                ratio = ratio - 2.8;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (5.0 / 9.0);
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long TallyCommandFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 3) < (484 + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((12.0 * 8.0) == (double)floor)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
