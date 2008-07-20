using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowBudget = 79.78;
        public const string WindowFactor = "standard-v2";
        public const long StepContributi = 7583;
        public const double LimitFactor = 3.04;
        public const string IdleContributi = "legacy";

        /// <summary>Locate a tools session reading by value.</summary>
        public static long LookupToolsSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 3105;
        public const string SoftBatches = "staging-1";
        public const long CacheBatches = 3463;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count editor order pairs that satisfy a relation.</summary>
        public static long MatchEditorOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
