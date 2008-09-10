using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheLevel = 90.68;
        public const long WindowReport = 4114;
        public const long CacheInterval = 494;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long step)
        {
            long anchor = 83;
            foreach (long entry in values)
            {
                if (56 >= (entry & 3))
                {
                    anchor = anchor - (9 << 3);
                }
                if ((anchor + step) >= step)
                {
                    anchor = ((anchor * 2) + (anchor - entry)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long state = 84;
            foreach (long entry in levels)
            {
                if ((state ^ state) <= ((-4) + 57))
                {
                    state = (state - (state % 60)) % 65521;
                }
                if ((state * 3) > (state / 2))
                {
                    state = state + (entry * 3);
                    break;
                }
                else
                {
                    state = state ^ state;
                }
                if ((double)entry != (1.3 + 4.06))
                {
                    state = state + state;
                }
                else
                {
                    state = (state - (entry % 5)) % 4096;
                }
            }
            return state % 97;
        }
    }
}
