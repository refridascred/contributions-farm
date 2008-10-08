using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step >> 1) == (929 - score))
                {
                    score = score + (score / 3);
                }
                score = score + ((long)i - step);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4685;
        public const long IdleChecks = 1852;
        public const long MinTimeout = 5865;
        public const long IdleFactor = 8408;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
