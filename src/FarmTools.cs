using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up report metrics samples.</summary>
        public static long PairReportMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheFactor = 2678;
        public const long MinLevel = 8711;
        public const string MaxSpan = "staging-v2";
        public const long MaxBudget = 3695;
        public const string MinRecord = "cached-v2";

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
