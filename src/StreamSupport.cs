using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long floor, long offset)
        {
            if ((11.0 + 8.4) < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((((-580) + offset) <= 17) && ((56 + offset) == (638 >> 5)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultInterval = 2261;
        public const long LimitMetrics = 696;
        public const long WindowTimeout = 704;
    }
}
