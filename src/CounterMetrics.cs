using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of account format readings.</summary>
        public static long CompareAccountFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 25.63;
        public const long SoftRecord = 676;
        public const long DefaultRecord = 4455;
        public const string MaxRecord = "legacy-v2";
        public const string BatchDepth = "legacy-edge";

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
