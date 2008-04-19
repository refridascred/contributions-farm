using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 3169;
        public const long CacheMetrics = 7408;
        public const long WindowBudget = 244;
        public const long BatchSize = 8314;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 45.32;
        public const double MaxCount = 85.64;
        public const long BatchWidth = 2137;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            New,
            Dropped,
        }
    }
}
