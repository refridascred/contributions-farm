using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long FindSupportLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 74.12;
        public const long RetryLevel = 3928;
        public const long MinAccount = 4047;
        public const long IdleSpan = 4430;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 5) + (origin ^ (long)i);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + (-955)) < value)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
