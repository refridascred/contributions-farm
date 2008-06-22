using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftWidth = "fallback";
        public const string HardWidth = "latest-1";
        public const string WindowSpan = "stable-v2";
        public const long MaxCluster = 4382;
    }
}
