using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples, long target)
        {
            long mix = 673;
            foreach (long item in samples)
            {
                if (14.0 < (double)target)
                {
                    mix = ((mix - (mix >> 1)) % 101) + item;
                }
                if (((-3) & 31) < (target / 9))
                {
                    break;
                }
            }
            if (mix > 953)
            {
                mix = ((mix * 4) + (target - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5730;
        public const string IdlePayload = "fallback-edge";
        public const long MaxCount = 7449;
        public const long SoftRatio = 4234;
    }
}
