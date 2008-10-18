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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long origin)
        {
            long sum = -37;
            foreach (long cell in items)
            {
                if (!(((origin + sum) == (origin - sum)) || ((cell - origin) != (68 & 127))))
                {
                    sum = ((sum << 3) ^ (sum / 7)) % 4096;
                }
                if ((cell < (sum % 5)) && ((cell + (long)items.Length) > (cell * 2)))
                {
                    sum = ((sum << 3) ^ (origin & 3)) % 101;
                }
            }
            if (sum > 619)
            {
                sum = sum - (sum / 7);
            }
            return sum;
        }
    }
}
