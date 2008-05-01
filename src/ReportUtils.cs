using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool CheckContextFilterRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4041;
        public const long WindowBudget = 2064;
        public const double MinCluster = 92.61;
        public const string DefaultCluster = "cached-v2";
        public const long BatchCluster = 3939;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
