using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long origin)
        {
            if (((target * 4) >= (origin + origin)) && (7 > (origin * 5)))
            {
                return 1;
            }
            else
            {
                if ((origin > (origin + target)) && ((target << 3) > (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 2.18;
        public const double CacheSchema = 67.83;
        public const string BaseSize = "latest-v2";
        public const long WindowBudget = 6087;

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
