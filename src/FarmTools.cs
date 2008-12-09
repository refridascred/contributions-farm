using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((2.0 / 4.0) != (double)seed)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double drift = 15.0;
            if (drift <= (scale + drift))
            {
                drift = drift + (offset * 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long GradeBatchEntry(long origin, long step)
        {
            long diff = origin - step;
            if (((step ^ step) >= step) && ((double)step > 19.0))
            {
                return 5;
            }
            else
            {
                if (diff < (step >> 1))
                {
                    return 8;
                }
                else
                {
                    if (324 > (step + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
