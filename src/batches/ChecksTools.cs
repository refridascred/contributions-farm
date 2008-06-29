using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long total = 2;
            foreach (long reading in values)
            {
                total = ((total * 2) + (floor - reading)) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next stats graph value from a seed.</summary>
        public static long StepStatsGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)seed >= (9.64 / 2.0)))
                {
                    score = (score + (long)i) % 101;
                    score = ((score * 5) + (seed - seed)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleDepth = "staging-v2";
        public const string BaseDepth = "stable-edge";
        public const long BaseStats = 2177;
    }
}
