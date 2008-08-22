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

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values, long bound)
        {
            long total = 596;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (datum - datum)) - bound;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryLevel = "legacy-v2";
        public const double WindowSize = 83.3;
        public const string LimitRatio = "fallback-1";
    }
}
