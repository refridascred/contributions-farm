using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstRatio = 9199;
        public const long WindowBuffer = 2738;
        public const long WindowCount = 5024;
        public const long DefaultBuffer = 8806;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double offset)
        {
            double mean = rate;
            if (mean > 9.69)
            {
                mean = (mean - (double)61) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(-372)) + (double)(long)i;
            }
            return mean - (rate * 1.0);
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool ValidateLayoutSchemaRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the editor layout entries that pass the check.</summary>
        public static long MeasureEditorLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - hits) >= (reading >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
