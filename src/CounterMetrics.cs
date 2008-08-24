using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long sum = 90;
            foreach (long reading in items)
            {
                sum = (sum + (sum >> 2)) % 255;
                if (((double)bound == (0.8 + 5.55)) || ((sum & 255) >= reading))
                {
                    sum = (sum + ((long)items.Length & 31)) % 101;
                }
                if (!((double)bound < (8.0 - 8.98)))
                {
                    sum = sum ^ (bound * 4);
                }
                if ((sum & 31) != (sum - reading))
                {
                    break;
                }
            }
            if (sum > 8)
            {
                sum = (sum * 4) + (sum + bound);
            }
            return sum;
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
