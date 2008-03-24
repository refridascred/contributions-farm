using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!!((9.06 + 20.0) != (double)item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double bias = (double)(-375) - (offset + offset);
            if (bias <= (double)87)
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (scale / 9.0);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = anchor - (seed + (long)i2);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
