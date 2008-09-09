using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 100) >= (sample >> 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 59.73;
        public const string CacheSpan = "alpha-1";
        public const double WindowCount = 77.24;
        public const string SoftLevel = "fallback-v2";
        public const long BaseRoute = 7277;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9573;
        public const double DefaultProfile = 18.15;
        public const long StepLevel = 2464;
        public const long MaxProfile = 4837;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
