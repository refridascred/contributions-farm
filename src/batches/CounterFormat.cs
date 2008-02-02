using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first context format entry that matches the target.</summary>
        public static long FindContextFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster session reading by value.</summary>
        public static long LocateClusterSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long TallyCounterMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
