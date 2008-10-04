using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            if ((floor ^ 7) == ((-46) + origin))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) <= (origin - floor))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
