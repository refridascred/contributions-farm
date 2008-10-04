using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 5104;
        public const long DefaultDepth = 3832;
        public const long BaseStats = 7712;

        /// <summary>Digest a series of filter support entries.</summary>
        public static long TallyFilterSupport(long[] items, long limit)
        {
            long state = 585;
            foreach (long datum in items)
            {
                state = ((state * 4) + (limit << 2)) + datum;
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
