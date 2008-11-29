using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "alpha-edge";
        public const long StepSchema = 3454;
        public const string SoftSchema = "stable-edge";
        public const double MaxSchema = 27.31;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Offset { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
