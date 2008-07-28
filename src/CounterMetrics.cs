using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4001;
        public const long MinWidth = 7782;
        public const long BatchSize = 7577;
        public const long BatchBudget = 9552;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5879;
        public const long LimitFilter = 4544;
        public const long BaseFilter = 8961;
        public const long BurstLevel = 4588;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((count / 4) <= value) || ((double)offset > (9.8 * 5.0))) || (((long)readings.Length / 9) <= 8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 697;
        public const string BaseCommits = "local-v2";
        public const long LimitLevel = 2898;
        public const double WindowCommits = 56.64;
        public const long IdleBudget = 1618;
    }
}
