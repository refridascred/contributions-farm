using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of already format readings.</summary>
        public static long CompareAlreadyFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 3163;
        public const long IdleQueue = 6874;
        public const long StepBudget = 564;
        public const string BaseSize = "alpha-1";
    }
}
