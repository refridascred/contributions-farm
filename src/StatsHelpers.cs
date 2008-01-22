using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics githubfarm readings against a rule.</summary>
        public static long MeasureMetricsGithubfarmHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell > (cell + 14))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)59 >= (double)matches)
                {
                    matches = ((matches + 2) ^ sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 57;
        public const long MinScore = 9956;
        public const string IdleCount = "primary";
        public const long BatchDepth = 1233;
        public const long SoftChannel = 8885;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            New,
            Dropped,
            Idle,
        }
    }
}
