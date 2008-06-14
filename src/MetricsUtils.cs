using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowScore = 5050;
        public const string HardDepth = "latest-1";
        public const long SoftFactor = 8103;
        public const long DefaultCommits = 4370;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 9459;
        public const string StepSupport = "alpha-edge";
        public const long LimitSupport = 72;
        public const long IdleSupport = 8983;

        /// <summary>Roll a batches session counter forward.</summary>
        public static long RollBatchesSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (219 / 2);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (7 + 364))
                {
                    hits = ((hits + 1) + value) - target;
                }
            }
            return hits;
        }
    }
}
