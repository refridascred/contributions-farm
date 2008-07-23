using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Mode { get; set; } = "";
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
