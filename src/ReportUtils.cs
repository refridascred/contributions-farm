using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command already samples.</summary>
        public static long DigestCommandAlready(long[] data, long bound)
        {
            long sum = 447;
            foreach (long reading in data)
            {
                if (((reading + sum) >= sum) && ((double)reading == (7.5 + 9.1)))
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = (sum + (reading + 994)) % 101;
                    sum = (sum ^ (reading + bound)) % 255;
                }
                if (sum < reading)
                {
                    sum = (sum ^ (sum % 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long total = 6;
            foreach (long value in series)
            {
                if ((6.37 <= (double)total) || ((double)value >= 3.0))
                {
                    total = ((total << 3) ^ (value ^ (long)series.Length)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepScore = "staging-1";
        public const string BatchDepth = "local";
        public const double LimitSize = 62.9;
        public const double DefaultStream = 43.41;
    }
}
