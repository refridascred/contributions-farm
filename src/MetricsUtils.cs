using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many checks contributi samples are out of range.</summary>
        public static long AuditChecksContributiMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 6) <= (count - (-27)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes filter entry stays within the limit.</summary>
        public static bool GuardNotesFilterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9762;
        public const string StepInterval = "primary-1";
        public const long SoftToken = 4137;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7290;
        public const string LimitBuffer = "alpha";
        public const long BurstBuffer = 5367;
        public const long HardTimeout = 5896;
        public const string MaxDepth = "strict-edge";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
