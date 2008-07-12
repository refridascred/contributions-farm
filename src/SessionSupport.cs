using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > 4.5)
            {
                scale2 = scale2 + (scale * 9.4);
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + (scale2 - floor);
        }

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long CountBufferRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (1.0 * 7.8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long TallyGraphToolsGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (hits / 9))
                {
                    hits = ((hits + 3) ^ sample) + floor;
                }
            }
            return hits;
        }
    }
}
