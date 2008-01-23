using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a batches already pair into a bucket.</summary>
        public static long GradeBatchesAlready(long target, long step)
        {
            if (((1.6 + 3.9) > (double)step) && ((step + 5) <= (7 ^ step)))
            {
                return 5;
            }
            else
            {
                if (target <= (target + 0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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
