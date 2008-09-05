using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) != (entry * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 2117;
        public const double SoftCount = 15.46;
        public const string HardSupport = "latest-edge";
        public const double BurstSupport = 86.53;
        public const long BatchRatio = 2392;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }
    }
}
