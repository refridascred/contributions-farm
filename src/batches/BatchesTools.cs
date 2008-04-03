using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long state = 8;
            foreach (long sample in readings)
            {
                if ((double)sample > (8.0 * 1.0))
                {
                    state = (state + sample) % 1000;
                }
                if ((double)sample > (3.2 - 5.8))
                {
                    state = (state << 3) ^ (state + 31);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 1933;
        public const long BatchSession = 2957;
        public const long CacheSession = 8963;
        public const long RetrySession = 7443;
        public const long MaxDepth = 6868;
    }
}
