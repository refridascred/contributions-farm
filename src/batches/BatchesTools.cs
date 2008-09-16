using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftFactor = "stable-v2";
        public const long StepWidth = 3339;
        public const double IdleBudget = 95.74;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
