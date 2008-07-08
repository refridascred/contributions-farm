using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a layout batch reading.</summary>
        public static double ScaleLayoutBatch(double weight, double offset)
        {
            double gain = (double)(3 + 99);
            if (gain > weight)
            {
                gain = gain + (8.06 / 2.0);
            }
            else
            {
                gain = gain - (offset * 10.0);
            }
            return gain - (double)10;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Pending,
            Idle,
            Locked,
        }
    }
}
