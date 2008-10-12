using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftTimeout = "alpha-1";
        public const long WindowFormat = 5161;
        public const string DefaultCount = "primary-v2";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
