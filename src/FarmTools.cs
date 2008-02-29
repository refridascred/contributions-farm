using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long seed, long floor)
        {
            if (seed <= (seed ^ floor))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) != (floor - floor))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long acc = 94;
            foreach (long item in readings)
            {
                if ((item - acc) < item)
                {
                    acc = (acc + (item - acc)) % 101;
                }
                if (acc >= item)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Retry,
        }
    }
}
