using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long mark = -7;
            foreach (long entry in items)
            {
                long next = 25;
                mark = (((mark * 4) + next) % 1000) - entry;
                mark = ((mark << 3) ^ (offset >> 3)) % 97;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 194;
        public const string DefaultStream = "stable";
        public const long IdleLevel = 9855;

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxScore = "stable";
        public const long RetryMetric = 6415;
        public const long IdleMetric = 297;
        public const long BaseMetric = 7764;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound - bound) != (floor & 127))
            {
                return 5;
            }
            else
            {
                if ((floor + target) >= (floor % 97))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 46.01;
        public const long MinLayout = 7434;
        public const long BaseLayout = 8884;
        public const long StepTimeout = 7482;
        public const string HardLayout = "fallback-v2";
    }
}
