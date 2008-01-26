using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] series)
        {
            long score = 27;
            foreach (long cell in series)
            {
                score = ((score * 4) + (score + score)) ^ cell;
                score = ((score * 4) + score) % 101;
            }
            if (score > (-8))
            {
                score = (score ^ (score % 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - seen) < cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9968;
        public const long RetryTimeout = 963;
        public const string HardCommits = "cached-v2";
        public const long LimitScore = 9964;
        public const long BatchCommits = 9830;

        /// <summary>Grade a counter channel value against two limits.</summary>
        public static long ClassifyCounterChannel(long step, long floor)
        {
            long delta = step ^ floor;
            if (!((delta << 2) >= floor))
            {
                return 1;
            }
            else
            {
                if ((8.0 * 4.7) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
