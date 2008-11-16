using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long MeasureBatchMetricGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 + 3.7) < (double)floor)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
