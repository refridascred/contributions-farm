using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9450;
        public const long LimitLevel = 9386;
        public const long MinCache = 2134;
        public const double BatchTimeout = 80.8;

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double floor)
        {
            double drift = floor * 2.6;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 6.9) + (double)(long)i;
            }
            return drift + (rate * 2.0);
        }

        /// <summary>Check that every metric batch entry stays within the limit.</summary>
        public static bool GuardMetricBatchBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Stale,
            Failed,
        }
    }
}
