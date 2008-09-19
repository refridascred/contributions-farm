using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next metric payload value.</summary>
        public static double BlendMetricPayload(double gain, double floor)
        {
            double mean = (gain + floor) + (9.7 * 1.25);
            if (mean >= (mean - gain))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (16.0 * 5.33);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 49.45;
        public const double MinSupport = 66.19;
        public const double HardLevel = 17.94;
        public const long DefaultSupport = 5357;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (anchor % 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((19 % 97) > cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
