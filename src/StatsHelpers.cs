using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading > 5.46)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultDepth = 1318;
        public const long CacheInterval = 2913;
        public const long MaxContext = 9673;
        public const long IdleInterval = 4932;
        public const double WindowScore = 45.85;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
