using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
