using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((0 + (long)values.Length) == (sample * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a entry metric reading by value.</summary>
        public static long FindEntryMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
