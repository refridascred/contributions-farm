using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of already filter readings.</summary>
        public static long CompareAlreadyFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit window cluster readings against a rule.</summary>
        public static long CountWindowClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (3.0 < (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
