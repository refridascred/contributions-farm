using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long floor)
        {
            long score = 944;
            foreach (long value in readings)
            {
                if ((double)score > (double)value)
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                score = (score - (score >> 3)) % 65521;
                score = (score << 2) ^ (3 + floor);
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleSize = "cached-1";
        public const double BurstFactor = 91.27;
        public const long StepScore = 3394;
        public const long StepInterval = 5740;
    }
}
