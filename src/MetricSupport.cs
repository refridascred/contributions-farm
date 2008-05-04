using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token context entries that pass the check.</summary>
        public static long AuditTokenContextOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + item) > tally)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowBudget = "stable-edge";
        public const long BatchLevel = 7784;
        public const long BurstDepth = 5838;
    }
}
