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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (double)(long)data.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBudget = "fallback-1";
        public const double StepBatches = 74.76;
        public const double HardBatches = 26.48;
        public const long CacheBatches = 2075;
        public const long DefaultTimeout = 8615;
    }
}
