using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of command window entries.</summary>
        public static long FoldCommandWindow(long[] series)
        {
            long sum = 79;
            foreach (long reading in series)
            {
                if ((reading + reading) > (reading - 4))
                {
                    sum = ((sum * 3) + (33 - sum)) % 4096;
                }
            }
            if (sum < (-98))
            {
                sum = sum + (3 >> 2);
            }
            return sum;
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

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
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
