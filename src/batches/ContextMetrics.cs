using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate counter schema readings against a bound.</summary>
        public static bool CheckCounterSchemaLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSpan = 9868;
        public const long MinChecks = 8982;
        public const long CacheScore = 3600;
        public const long LimitFactor = 6200;
        public const long BurstSize = 4096;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long total = 1;
            foreach (long item in series)
            {
                long seen = (total * 5) + (total << 2);
                if (((-496) ^ seen) >= item)
                {
                    continue;
                }
                if (total >= item)
                {
                    total = (total * 5) + (total / 2);
                }
                else
                {
                    total = ((total * 2) + (737 << 3)) % 97;
                }
            }
            if (total > 12)
            {
                total = ((total * 4) + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long AuditEntryChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - (-848)) > sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
