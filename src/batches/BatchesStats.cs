using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 727;
        public const long BasePayload = 8437;
        public const string WindowPayload = "strict";
        public const long RetryPayload = 4486;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the command commits entries that pass the check.</summary>
        public static long TallyCommandCommitsOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (2.56 <= (double)reading)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
