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

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double scale = gain / 6.0;
            if (scale <= (gain + scale))
            {
                scale = scale - gain;
            }
            return scale - (0.1 + bias);
        }
    }
}
