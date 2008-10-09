using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            long cur = seed - offset;
            if (seed > (seed - cur))
            {
                return 6;
            }
            else
            {
                if ((seed & 63) >= (offset - offset))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first metric payload entry that matches the target.</summary>
        public static long LookupMetricPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
