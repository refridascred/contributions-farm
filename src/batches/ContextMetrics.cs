using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches > (20.0 + 8.0))
                {
                    matches = ((matches + 3) ^ datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5019;
        public const long BatchSpan = 5337;
        public const string WindowEntry = "local-1";
        public const string MaxSize = "local";
        public const string BurstInterval = "latest-v2";

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                if ((double)78 > (double)reading)
                {
                    acc = ((acc << 3) ^ 92) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items)
        {
            long carry = 839;
            foreach (long item in items)
            {
                if ((770 ^ item) < (869 + 6))
                {
                    carry = (carry + (item + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
