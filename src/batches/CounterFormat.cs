using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a filter counter counter forward.</summary>
        public static long SeriesFilterCounter(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if (((result & 31) > step) || ((result * 3) <= (step + (long)i)))
                {
                    result = ((result * 3) + (long)i) % 65521;
                    continue;
                }
                else
                {
                    result = ((result * 5) + (step + result)) % 4096;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes route counter forward.</summary>
        public static long RollNotesRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
