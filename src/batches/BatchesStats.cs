using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6184;
        public const long IdleRatio = 8946;
        public const string CacheDepth = "staging";
        public const long RetryBuffer = 6288;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = (total * 3) + total;
                total = (total + cell) % 255;
            }
            return total % 65521;
        }

        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool GuardSupportSchemaBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Active,
            Paused,
            Idle,
        }
    }
}
