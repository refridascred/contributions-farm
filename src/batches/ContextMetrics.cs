using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            New,
            Draft,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultCount = "local-edge";
        public const long WindowDepth = 2792;
        public const long CacheCount = 9029;
        public const long CacheBatch = 7902;
        public const long StepLevel = 6333;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if (((773 << 2) >= (floor * 5)) || ((double)bound <= (3.25 + 1.4)))
            {
                return 2;
            }
            else
            {
                if (!((double)floor < (9.8 * 8.23)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
