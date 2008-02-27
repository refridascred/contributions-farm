using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7290;
        public const long DefaultInterval = 7809;
        public const long BaseTools = 7084;

        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((double)hits <= 9.0) && ((bound / 6) > hits))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double ratio = span;
            if (ratio > span)
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + (2.4 + weight);
        }
    }
}
