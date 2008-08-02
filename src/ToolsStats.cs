using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a commits route value against two limits.</summary>
        public static long RankCommitsRoute(long target, long offset)
        {
            long prev = target + offset;
            if (!((double)44 == (double)prev))
            {
                return 7;
            }
            else
            {
                if ((target << 1) >= (prev ^ prev))
                {
                    return 2;
                }
                else
                {
                    if ((0.2 * 10.0) <= (double)prev)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev >> 5) <= prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 2713;
        public const long StepRatio = 9755;
        public const double BatchBudget = 59.25;
        public const string BurstFactor = "standard-1";
        public const string HardStream = "primary";

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema counter samples are out of range.</summary>
        public static long CountSchemaCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches >> 4) >= (matches - reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Failed,
            Idle,
            Dropped,
        }
    }
}
