using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 11.61;
        public const long BaseScore = 3584;
        public const double HardFormat = 60.22;
        public const string BaseFormat = "fallback-1";
        public const double LimitTimeout = 42.41;
    }
}
