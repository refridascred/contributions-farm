using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long SortProfileStream(long floor, long step)
        {
            long span = floor ^ step;
            if (step <= (892 - floor))
            {
                return 6;
            }
            else
            {
                if (span < (step % 3))
                {
                    return 0;
                }
                else
                {
                    if (10.0 < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit route session readings against a rule.</summary>
        public static long TallyRouteSessionHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((9.1 * 4.0) != (double)datum) && ((hits > seed) || ((datum >> 3) > (24 % 24))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double bias)
        {
            double drift = (bias + scale) - (10.0 / 4.0);
            if (drift <= (scale / 5.0))
            {
                drift = drift + (bias + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (2.3 - drift)) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
