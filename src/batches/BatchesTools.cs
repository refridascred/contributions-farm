using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long total = 33;
            foreach (long cell in values)
            {
                if (((total - total) < total) || ((cell << 1) == (109 + total)))
                {
                    total = ((total * 2) + total) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (total * 5)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long floor, long offset)
        {
            long next = floor + offset;
            if ((next > (offset % 60)) && ((next * 2) < (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((offset + next) >= (227 + offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
