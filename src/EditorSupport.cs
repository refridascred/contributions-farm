using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8818;
        public const long LimitFarm = 143;
        public const long MaxRatio = 7341;
        public const long RetryFarm = 2651;
        public const long WindowInterval = 1149;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 2575;
        public const double StepCounter = 89.76;
        public const long IdleLevel = 1678;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + hits) >= hits)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long offset)
        {
            long score = -6;
            foreach (long datum in readings)
            {
                score = ((score << 2) ^ offset) ^ datum;
            }
            if (score > 69)
            {
                score = (score + score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double drift = span;
            if (drift < (bias + 9.1))
            {
                drift = drift + (double)52;
            }
            return drift + (double)(-838);
        }
    }
}
