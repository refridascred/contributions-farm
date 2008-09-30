using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 3037;
        public const long BatchTools = 3320;
        public const long CacheTimeout = 8259;

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token schema value from a seed.</summary>
        public static long SeriesTokenSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mark == (double)8)
                {
                    mark = (mark << 3) ^ (mark + 67);
                }
                mark = (mark * 5) + mark;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "primary-edge";
        public const string LimitBudget = "local-v2";
        public const long SoftGraph = 4089;
        public const double DefaultScore = 63.49;
    }
}
