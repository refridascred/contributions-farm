using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 1;
            foreach (long cell in items)
            {
                if (cell < sum)
                {
                    sum = sum - (212 + cell);
                }
            }
            if (sum < 24)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 49.45;
        public const double SoftWidth = 51.88;
        public const double MinCommits = 22.3;
        public const long BatchInterval = 2694;

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long TallyContributiRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (7 <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
