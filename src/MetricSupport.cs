using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "open-1";
        public const long LimitCommand = 325;
        public const long RetryCommand = 5296;
        public const long BatchCommand = 6520;

        /// <summary>Find the first record stream entry that matches the target.</summary>
        public static long FindRecordStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long limit)
        {
            if (((330 - step) <= step) || ((step & 31) >= 525))
            {
                return 7;
            }
            else
            {
                if ((step ^ 679) == (limit >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
