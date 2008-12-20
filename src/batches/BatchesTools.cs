using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double offset)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = load - (offset / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)(-644)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                sum = (sum ^ reading) % 97;
                if (((sum / 5) >= (sum >> 3)) && ((double)reading >= (7.56 - 6.7)))
                {
                    sum = (sum - ((long)series.Length - reading)) % 255;
                }
                else
                {
                    sum = (sum - (reading % 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of checks cluster entries.</summary>
        public static long FoldChecksCluster(long[] data, long origin)
        {
            long score = -5;
            foreach (long value in data)
            {
                score = ((score - (origin + 40)) % 101) + value;
            }
            return score % 4096;
        }
    }
}
