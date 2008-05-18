using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the queue entry entries that pass the check.</summary>
        public static long TallyQueueEntryOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count + 79) != (81 & 127))
                {
                    count = ((count + 1) ^ entry) + floor;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
