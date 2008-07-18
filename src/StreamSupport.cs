using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload format value against two limits.</summary>
        public static long BucketPayloadFormat(long offset, long target)
        {
            long delta = offset - target;
            if ((double)target > (7.0 / 6.0))
            {
                return 5;
            }
            else
            {
                if (!((target >> 3) < (target - delta)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) < (884 ^ item))
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
