using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long limit)
        {
            long sum = 89;
            foreach (long cell in data)
            {
                sum = ((sum ^ (limit / 3)) % 4096) ^ cell;
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally << 2) > (limit + (long)values.Length))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats notes figure with a bias.</summary>
        public static double AdjustStatsNotes(double ratio, double offset)
        {
            double weight = ratio;
            return weight - (ratio - offset);
        }
    }
}
