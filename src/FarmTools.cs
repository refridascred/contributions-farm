using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count account order pairs that satisfy a relation.</summary>
        public static long CompareAccountOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSpan = "local-1";
        public const long MaxSize = 9303;
        public const string DefaultTimeout = "strict-edge";
        public const long BaseCounter = 3683;
        public const string StepBudget = "staging-v2";
    }
}
