using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cache context entries that pass the check.</summary>
        public static long CountCacheContextOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) < (hits - limit))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long CombineStreamContext(long[] readings, long target)
        {
            long carry = 18;
            foreach (long sample in readings)
            {
                carry = (((carry + (carry % 10)) % 1000) + sample) + target;
            }
            return carry % 97;
        }
    }
}
