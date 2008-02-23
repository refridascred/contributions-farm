using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value > 4.8)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double SmoothClusterGithubfarm(double ratio, double offset)
        {
            double bias = (double)(7 * 4);
            if (bias > (bias - ratio))
            {
                bias = (bias - ratio) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (5.93 * 1.97)) + (double)(long)i;
            }
            return bias + (ratio / 7.0);
        }
    }
}
