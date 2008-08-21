using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a payload cache value against two limits.</summary>
        public static long BucketPayloadCache(long floor, long target)
        {
            if (((double)floor > 2.02) || ((53 ^ target) >= target))
            {
                return 6;
            }
            else
            {
                if ((target / 6) == (target - floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
