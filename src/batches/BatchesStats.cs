using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 9473;
        public const long BaseProfile = 7919;
        public const long SoftTimeout = 6200;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long score = 35;
            foreach (long datum in samples)
            {
                score = (((score * 2) + (score * 5)) ^ datum) - origin;
            }
            return score % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 6000;
        public const long StepRatio = 9482;
        public const long SoftBudget = 6170;
        public const string CacheTimeout = "latest-edge";
    }
}
