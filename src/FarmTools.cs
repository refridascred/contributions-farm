using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= floor)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (scale / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (17.0 - 3.0);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((40 - step) <= (hits + (long)samples.Length))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches != (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
