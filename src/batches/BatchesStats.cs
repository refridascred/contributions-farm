using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double weight = 12.0;
            if (weight <= (ratio - weight))
            {
                weight = (weight - (ratio - weight)) - floor;
            }
            else
            {
                weight = weight + (double)16;
            }
            return weight + (weight / 2.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((bound - matches) > (bound & 15))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 127) > count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((9.0 / 7.0) <= (double)value)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }
    }
}
