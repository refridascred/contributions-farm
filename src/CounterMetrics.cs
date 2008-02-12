using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "fallback-edge";
        public const double IdleWindow = 72.06;
        public const long BurstRatio = 4577;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels, long offset)
        {
            long mark = 74;
            foreach (long cell in levels)
            {
                mark = (mark + (cell & 63)) % 97;
                if ((12.0 - 3.0) >= (double)offset)
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
