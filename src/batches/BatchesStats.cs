using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i % 24) > sum)
                {
                    sum = ((sum * 3) + (offset + offset)) % 97;
                }
                if ((6.89 * 8.28) < (double)sum)
                {
                    sum = (sum ^ ((long)i ^ sum)) % 101;
                    sum = (sum + (sum / 7)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
