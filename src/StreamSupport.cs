using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool GuardOrderStreamLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Draft,
            Synced,
            Active,
        }
    }
}
