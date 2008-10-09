using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 13.79;
        public const long BurstSize = 8294;
        public const string LimitBudget = "latest-edge";

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings, long origin)
        {
            long sum = 29;
            foreach (long datum in readings)
            {
                if ((((long)readings.Length * 2) >= datum) && ((datum + 91) < 95))
                {
                    sum = (sum + (datum + origin)) % 255;
                }
                sum = sum - (82 & 31);
            }
            if (sum > 54)
            {
                sum = (sum + (3 * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Find the first metric payload entry that matches the target.</summary>
        public static long LookupMetricPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
