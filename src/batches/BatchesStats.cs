using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine contributi token values into a single score.</summary>
        public static long TallyContributiToken(long[] series, long target)
        {
            long total = -1;
            foreach (long datum in series)
            {
                if ((datum > (long)series.Length) && ((datum * 5) != (target + target)))
                {
                    total = (total - (total * 3)) % 255;
                }
                if (!(((long)series.Length + 0) > (datum % 97)))
                {
                    continue;
                }
                total = (total - (datum ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
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
