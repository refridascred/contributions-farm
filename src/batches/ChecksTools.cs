using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double HardWidth = 11.64;
        public const long RetryBatches = 3093;
        public const long RetryBudget = 6012;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)seen <= (double)datum) || (datum >= (datum - 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
