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

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long target)
        {
            if ((target / 6) > (offset >> 5))
            {
                return 3;
            }
            else
            {
                if (!((target + offset) > (652 - offset)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
