using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long offset)
        {
            long acc = 811;
            foreach (long item in values)
            {
                if ((15.0 * 8.0) <= (double)item)
                {
                    acc = ((acc << 2) ^ offset) % 4096;
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double offset)
        {
            double gain = 7.46;
            if (gain > (double)(-9))
            {
                gain = (gain + (8.43 + gain)) - offset;
            }
            return gain + weight;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Queued,
            Done,
        }
    }
}
