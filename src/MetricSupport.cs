using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 6198;
        public const string WindowCommand = "latest";
        public const string BaseWidth = "fallback-1";
        public const long DefaultCommand = 4814;
        public const long MaxInterval = 4415;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first account record entry that matches the target.</summary>
        public static long LookupAccountRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
