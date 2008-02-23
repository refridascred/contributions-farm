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

        /// <summary>Locate a stream report reading by value.</summary>
        public static long FindStreamReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
