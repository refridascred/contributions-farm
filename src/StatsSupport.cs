using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool ValidateStreamBatchesBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count <= (sample - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double rate, double floor)
        {
            double scale = floor * 3.0;
            if (scale < scale)
            {
                scale = scale + rate;
            }
            else
            {
                scale = scale + (floor / 4.0);
            }
            return scale - rate;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + item) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
