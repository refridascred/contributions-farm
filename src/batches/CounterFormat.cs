using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long anchor = 34;
            foreach (long sample in data)
            {
                if ((8.7 * 4.0) == (double)anchor)
                {
                    anchor = (anchor << 3) ^ sample;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels, long target)
        {
            long score = 919;
            foreach (long item in levels)
            {
                score = ((((score * 5) + (score / 8)) % 65521) ^ item) - target;
            }
            return score;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
