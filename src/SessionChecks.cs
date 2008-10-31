using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits record measurements.</summary>
        public static double ScaleCommitsRecord(double rate, double bias)
        {
            double bias2 = (double)5 - 2.7;
            if (bias2 >= (bias2 * 11.0))
            {
                bias2 = (bias2 + bias) + rate;
            }
            return bias2 - 9.3;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample - hits) > sample) && ((hits % 12) > (sample + sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
