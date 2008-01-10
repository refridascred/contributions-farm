using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item < (hits / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double scale2 = floor - floor;
            if (scale2 > scale)
            {
                scale2 = scale2 + (double)12;
            }
            return scale2 - (scale * 9.5);
        }

        /// <summary>Audit cluster layout readings against a rule.</summary>
        public static long AuditClusterLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches * 2) <= (value - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next context schema value from a seed.</summary>
        public static long IterateContextSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed % 64) >= (8 - 20))
                {
                    total = (total ^ (seed + total)) % 97;
                    total = (total << 3) ^ (577 << 2);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
