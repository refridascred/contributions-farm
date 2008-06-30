using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many profile metric samples are out of range.</summary>
        public static long CountProfileMetricHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + origin) != (long)values.Length)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 7420;
        public const double MinSpan = 94.21;
        public const string MinBatches = "standard-edge";
        public const long RetryBatches = 2137;
        public const long DefaultRatio = 4379;
    }
}
