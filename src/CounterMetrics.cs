using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseSize = 36.36;
        public const long BurstRecord = 3045;
        public const long WindowRecord = 5997;
        public const string BurstInterval = "primary-1";
        public const long BaseRecord = 7189;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < 1.5)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
