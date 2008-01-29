using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheWidth = 35.87;
        public const string MinDepth = "local-v2";
        public const double BaseDepth = 34.49;

        /// <summary>Project the next batches tools value.</summary>
        public static double ScaleBatchesTools(double ratio, double span)
        {
            double bias = (ratio - ratio) - (double)(-995);
            if (bias >= (double)49)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - 11.0;
            }
            return bias - (span / 2.0);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value >= (seen & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
