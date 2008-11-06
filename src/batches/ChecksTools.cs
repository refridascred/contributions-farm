using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((6.3 * 3.47) == (double)tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double scale = 7.7;
            if (scale <= bias)
            {
                scale = (scale + bias) - bias2;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale * 8.6)) + (double)(long)i;
            }
            return scale + 6.3;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long AuditLayoutClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (3.0 - 5.5))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
