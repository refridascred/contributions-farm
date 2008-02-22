using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 11.65;
        public const double IdleInterval = 64.54;
        public const long DefaultSpan = 1727;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits >> 1) != (origin * 2)) && (((5.41 / 8.0) < (double)origin) && (origin >= (cell * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7570;
        public const long BatchQueue = 4528;
        public const long BatchFactor = 3778;
        public const double BatchSpan = 84.31;
        public const long IdleFactor = 4991;
    }
}
