using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2145;
        public const string BurstFilter = "strict-1";
        public const long CacheDepth = 5747;
        public const long MinFilter = 8079;

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstSize = "staging-1";
        public const long MinWidth = 5121;
        public const long BurstBudget = 4982;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((((long)i & 3) != (total % 8)) || ((origin - origin) > 129)))
                {
                    total = (total ^ (99 / 2)) % 255;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
