using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long BucketBufferChecks(long offset, long target)
        {
            if ((4.6 - 8.96) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (target <= 64)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
