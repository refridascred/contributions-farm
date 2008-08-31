using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 5298;
        public const long CacheCluster = 329;
        public const string BurstFactor = "legacy-edge";
        public const long HardInterval = 1377;
        public const long MinCluster = 8451;

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Match up batches record samples.</summary>
        public static long OverlapBatchesRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long floor)
        {
            if ((floor / 8) < floor)
            {
                return 0;
            }
            else
            {
                if (((17 + step) != (step % 24)) || ((3.0 + 4.6) <= (double)step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
