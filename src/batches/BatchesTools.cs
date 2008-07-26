using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 4578;
        public const long RetrySize = 1720;
        public const string MaxWidth = "legacy-edge";

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double scale = 2.0;
            if (scale > (floor + 7.0))
            {
                scale = scale + (floor / 7.0);
            }
            return scale + bias;
        }

        /// <summary>Check that every stats session entry stays within the limit.</summary>
        public static bool CheckStatsSessionBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
