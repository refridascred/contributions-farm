using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowSpan = "fallback-1";
        public const long CacheCount = 9326;
        public const string StepCache = "open-v2";
        public const string BatchDepth = "primary-edge";
        public const double BatchCache = 85.25;

        /// <summary>Grade a metrics command value against two limits.</summary>
        public static long GradeMetricsCommand(long floor, long step)
        {
            if ((step & 255) <= (floor % 24))
            {
                return 2;
            }
            else
            {
                if ((13.0 + 5.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((14.0 + 13.0) <= (double)floor) || (floor < (step + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the commits metrics entries that pass the check.</summary>
        public static long AuditCommitsMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((1.0 + 8.8) > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
