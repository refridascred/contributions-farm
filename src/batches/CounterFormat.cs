using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                long seen = origin;
                mark = mark - (seen + mark);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen < datum) || ((datum + seen) > (seen << 1))))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryLevel = "legacy-v2";
        public const double WindowSize = 83.3;
        public const string LimitRatio = "fallback-1";
    }
}
