using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels)
        {
            long mark = -57;
            foreach (long value in levels)
            {
                mark = (mark ^ (value % 60)) % 65521;
                if ((-1) <= (value + mark))
                {
                    mark = mark ^ (value << 3);
                }
            }
            if (mark < 5)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] data, long origin)
        {
            long state = 236;
            foreach (long entry in data)
            {
                state = ((state - (state - entry)) % 97) + origin;
            }
            return state % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBudget = "fallback-1";
        public const double StepBatches = 74.76;
        public const double HardBatches = 26.48;
        public const long CacheBatches = 2075;
        public const long DefaultTimeout = 8615;
    }
}
