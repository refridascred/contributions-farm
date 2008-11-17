using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "standard";
        public const long BurstBudget = 8905;
        public const string RetryContext = "cached-1";
        public const string BaseScore = "strict-edge";

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
