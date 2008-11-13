using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Look up the position of a metric contributi sample.</summary>
        public static long LocateMetricContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry >> 4) >= (entry + (long)readings.Length)) || ((1.2 + 1.8) < (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
