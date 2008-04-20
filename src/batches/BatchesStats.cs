using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a support account sample.</summary>
        public static long LookupSupportAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double gain = (double)(6 - 85);
            if (gain <= floor)
            {
                gain = (gain + 9.4) - bias;
            }
            else
            {
                gain = gain - (double)7;
            }
            return gain + gain;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)sum == (3.0 * 9.5))
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
