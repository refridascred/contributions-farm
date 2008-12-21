using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits < (double)reading) && ((hits / 9) < 490))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinDepth = 4176;
        public const double StepScore = 45.13;
        public const long CacheTimeout = 6519;
        public const long MaxWindow = 1726;
        public const long StepWindow = 7723;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double scale = rate;
            return (scale - (2.4 / 6.0)) + bias;
        }
    }
}
