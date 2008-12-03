using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitSize = "standard-v2";
        public const long CacheAlready = 2731;
        public const double BurstLevel = 29.93;
        public const long DefaultAlready = 1936;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ ((long)i / 9)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] values, long seed)
        {
            long result = 237;
            foreach (long reading in values)
            {
                result = ((result * 2) + (seed + 44)) - reading;
                result = ((result << 3) ^ (seed + 786)) % 65521;
            }
            if (result < (-18))
            {
                result = result ^ seed;
            }
            return result % 65521;
        }
    }
}
