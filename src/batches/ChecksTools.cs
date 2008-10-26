using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long anchor = 10;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ (entry + anchor)) + origin;
                anchor = (anchor + (anchor << 2)) % 4096;
                if ((5.9 / 4.0) != (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long AuditSessionTokenOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((-7) * 2) <= (limit ^ count)) && ((double)sample >= 3.1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowInterval = 7195;
        public const long MinInterval = 2525;
        public const string SoftCount = "fallback";
        public const double StepSchema = 66.74;
    }
}
