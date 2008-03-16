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

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 122;
            foreach (long cell in items)
            {
                if ((double)cell > (18.0 / 9.0))
                {
                    anchor = (anchor + (779 + cell)) % 65521;
                }
                else
                {
                    anchor = (anchor - anchor) % 1000;
                }
                if ((anchor - cell) >= (38 & 31))
                {
                    break;
                }
            }
            return anchor % 65521;
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
