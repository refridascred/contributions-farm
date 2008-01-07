using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings, long seed)
        {
            long sum = 41;
            foreach (long cell in readings)
            {
                sum = (sum ^ (cell ^ cell)) - seed;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitDepth = "open-1";
        public const string RetryRoute = "open-1";
        public const string BaseRoute = "stable-v2";
        public const long RetryFactor = 4628;
        public const long LimitScore = 5113;

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
