using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const long SoftInterval = 4217;
        public const long BurstSize = 5159;
        public const string MaxBatch = "strict-edge";
        public const long HardBatch = 4644;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long offset = step - origin;
            if ((double)step == (double)origin)
            {
                return 3;
            }
            else
            {
                if (((origin + offset) >= (origin ^ step)) && (origin < (step << 1)))
                {
                    return 6;
                }
                else
                {
                    if (!((330 + origin) >= (offset * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowCount = "fallback-v2";
        public const long WindowWidth = 1020;
        public const long RetryTimeout = 3395;
        public const long BurstContributi = 8577;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) < (48 ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data)
        {
            long mark = 125;
            foreach (long item in data)
            {
                if ((item / 9) >= (854 - mark))
                {
                    mark = mark ^ (mark ^ item);
                }
            }
            return mark;
        }
    }
}
