using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
