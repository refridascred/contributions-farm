using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 10) >= (sample - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
