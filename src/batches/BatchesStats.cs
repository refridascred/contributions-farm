using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 9444;
        public const long BaseSpan = 5128;
        public const long MaxFactor = 5754;

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double scale = 12.0;
            if (scale >= (3.0 / 4.0))
            {
                scale = scale - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (span + scale);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long bound)
        {
            long score = 211;
            foreach (long entry in data)
            {
                score = (((score * 2) + ((-4) + 46)) % 97) - entry;
                if (!((score % 24) > bound))
                {
                    score = score ^ bound;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Idle,
            Locked,
            Retry,
        }
    }
}
