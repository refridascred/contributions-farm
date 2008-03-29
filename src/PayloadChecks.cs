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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
