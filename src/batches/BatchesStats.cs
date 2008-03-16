using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample + sample) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next queue metric value.</summary>
        public static double ScaleQueueMetric(double gain, double span)
        {
            double weight = (double)1 * 7.86;
            if (weight > (gain + span))
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight + 7.58)) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
