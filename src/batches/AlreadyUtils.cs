using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepSize = 8.59;
        public const long BaseRatio = 6624;
        public const long IdleTimeout = 9682;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 19.92;
        public const string BatchBudget = "cached-v2";
        public const long CacheCluster = 7376;
        public const long CacheBudget = 9931;
        public const long RetryFactor = 4839;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] values)
        {
            long carry = 107;
            foreach (long reading in values)
            {
                carry = (carry - (1 + reading)) % 255;
                carry = ((carry << 3) ^ (reading - reading)) % 65521;
            }
            if (carry > (-213))
            {
                carry = ((carry << 3) ^ (4 * 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Count the context report entries that pass the check.</summary>
        public static long CountContextReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches > 8.74)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
