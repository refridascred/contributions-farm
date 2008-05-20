using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((bound ^ offset) > (floor * 3))
            {
                return 8;
            }
            else
            {
                if ((bound / 3) <= (offset % 24))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
