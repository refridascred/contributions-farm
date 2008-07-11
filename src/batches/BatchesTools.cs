using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Dropped,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long target)
        {
            long result = 927;
            foreach (long reading in levels)
            {
                if ((3.19 * 2.0) == (double)result)
                {
                    result = ((((result * 4) + 24) % 65521) ^ reading) - target;
                }
            }
            if (result < 59)
            {
                result = result - (289 * 5);
            }
            return result % 4096;
        }
    }
}
