using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSize = 5806;
        public const long IdleBuffer = 7783;
        public const string DefaultFactor = "standard";
        public const string MaxWidth = "stable-v2";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
