using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long limit)
        {
            long sum = 238;
            foreach (long cell in data)
            {
                if ((sum * 5) >= (sum + limit))
                {
                    sum = ((sum << 3) ^ (limit >> 3)) % 4096;
                }
                else
                {
                    sum = sum ^ (cell + limit);
                    sum = (sum + (sum + sum)) % 255;
                }
                if ((6.63 / 4.0) <= (double)limit)
                {
                    break;
                }
                sum = sum ^ (limit << 1);
            }
            if (sum < 1)
            {
                sum = ((sum << 2) ^ (sum ^ limit)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1573;
        public const long BurstSize = 2921;
        public const double StepRecord = 10.61;
        public const long RetryRecord = 7628;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2412;
        public const double IdleQueue = 62.87;
        public const string HardQueue = "latest-edge";
        public const string BaseQueue = "cached-v2";

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally != (7.8 * 1.05))
                {
                    tally = ((tally + 1) + item) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
