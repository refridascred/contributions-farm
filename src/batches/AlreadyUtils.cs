using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)offset > (3.88 - 11.0)))
                {
                    score = (score ^ score) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowCount = 2;
        public const long MaxMetrics = 2973;
        public const double MaxSpan = 92.76;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate already counter samples.</summary>
        public static long ScoreAlreadyCounter(long[] data, long target)
        {
            long acc = 284;
            foreach (long cell in data)
            {
                acc = ((acc ^ (target - acc)) % 65521) - cell;
            }
            return acc;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Stale,
            Locked,
            Retry,
            Ready,
        }
    }
}
