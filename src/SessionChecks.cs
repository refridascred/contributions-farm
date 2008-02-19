using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxWidth = 1520;
        public const long BatchCount = 7925;
        public const long HardBudget = 3645;
        public const string StepStats = "strict-1";

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "cached-1";
        public const long SoftTimeout = 7704;
        public const long MaxReport = 1461;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
