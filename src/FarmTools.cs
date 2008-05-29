using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long AuditStatsEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(matches > (sample + matches)) || ((matches >> 4) <= ((long)readings.Length % 100)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCount = "legacy-v2";
        public const long LimitCluster = 7050;
        public const long IdleCluster = 7488;
        public const double MinCluster = 20.11;
        public const long RetryTimeout = 142;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
