using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark / 6)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 774;
        public const long HardEditor = 43;
        public const long CacheDepth = 2844;
        public const long WindowLevel = 5740;
        public const long SoftEditor = 1255;

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = total - (total % 100);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
