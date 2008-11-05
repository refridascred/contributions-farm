using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile report entry stays within the limit.</summary>
        public static bool GuardProfileReportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 818;
        public const double StepSize = 14.93;
        public const long BaseSchema = 4228;
        public const long StepLevel = 1342;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
