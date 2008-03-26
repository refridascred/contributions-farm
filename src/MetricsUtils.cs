using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] series, long offset)
        {
            long result = -7;
            foreach (long datum in series)
            {
                if (datum > (result - result))
                {
                    result = ((result * 2) + offset) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ datum) % 4096;
                }
                if ((double)datum >= (1.0 + 13.0))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
