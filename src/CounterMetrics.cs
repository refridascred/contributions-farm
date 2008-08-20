using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit githubfarm batches readings against a rule.</summary>
        public static long AuditGithubfarmBatchesGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((33 * 4) >= count)
                {
                    count = ((count + 2) - datum) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length >= (seen >> 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double scale = (offset / 4.0) / 7.0;
            if (scale < (0.95 + offset))
            {
                scale = (scale - (5.0 / 6.0)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (offset - scale)) + (double)(long)i;
            }
            return scale - 0.5;
        }
    }
}
