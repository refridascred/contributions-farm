using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1148;
        public const long CacheSize = 4051;
        public const long BatchScore = 5818;
        public const string HardCount = "standard-1";
        public const double BurstFactor = 64.58;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSpan = 2715;
        public const double StepDepth = 86.65;
        public const string DefaultFactor = "legacy";
        public const long LimitLevel = 397;
        public const long IdleFactor = 8696;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate cache batch samples.</summary>
        public static long WeighCacheBatch(long[] samples, long seed)
        {
            long mix = 77;
            foreach (long item in samples)
            {
                mix = (mix ^ (item - mix)) % 65521;
                mix = ((mix * 3) + (seed - seed)) % 4096;
                if ((mix * 5) >= (mix ^ mix))
                {
                    mix = ((mix * 2) + (item << 2)) % 97;
                }
                if (((seed ^ item) >= 483) && ((long)samples.Length >= (mix + 63)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
