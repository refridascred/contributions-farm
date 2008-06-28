using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long result = 28;
            foreach (long entry in values)
            {
                result = (result ^ entry) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits window entries that pass the check.</summary>
        public static long CountCommitsWindowOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)limit > (5.9 - 11.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long state = 135;
            foreach (long item in series)
            {
                state = (state ^ (item / 2)) % 101;
                if ((1.96 + 10.0) <= (double)item)
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state << 3) ^ (state ^ (-852));
            }
            return state % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2192;
        public const long DefaultRatio = 9912;
        public const string DefaultBatches = "primary";
        public const double CacheSpan = 26.89;
    }
}
