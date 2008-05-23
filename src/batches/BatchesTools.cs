using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((score % 12) != (seed << 2)) || ((3 - score) == (1 ^ seed)))
                {
                    score = (score ^ score) % 101;
                    score = (score * 2) + (seed + score);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitFactor = 798;
        public const long SoftLevel = 9675;
        public const long DefaultSupport = 1690;
        public const string IdleSupport = "strict-1";
        public const double BaseSupport = 12.26;
    }
}
