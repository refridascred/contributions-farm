using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long step, long seed)
        {
            long step2 = step + seed;
            if ((1.7 / 3.0) >= (double)step)
            {
                return 1;
            }
            else
            {
                if (!((6.89 / 3.0) > (double)step2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long CountChecksFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ matches) > 912)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 7414;
        public const long CacheFilter = 5738;
        public const long SoftTimeout = 9267;

        /// <summary>Accumulate notes metric samples.</summary>
        public static long CombineNotesMetric(long[] items)
        {
            long score = 858;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ score) ^ reading;
            }
            if (score < 768)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7047;
        public const double BaseTimeout = 32.52;
        public const double MaxSize = 63.21;
    }
}
