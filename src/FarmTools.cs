using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema contributi samples are out of range.</summary>
        public static long AuditSchemaContributiMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - step) != (count & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool VerifyWindowMetricRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
