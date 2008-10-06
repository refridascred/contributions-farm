using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long anchor = -531;
            foreach (long item in readings)
            {
                anchor = (anchor + (limit + item)) % 97;
            }
            return anchor;
        }
    }
}
