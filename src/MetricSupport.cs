using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of already stats entries.</summary>
        public static long DigestAlreadyStats(long[] readings, long bound)
        {
            long mark = 753;
            foreach (long sample in readings)
            {
                mark = (mark - (mark * 3)) - sample;
                if (mark >= (4 + bound))
                {
                    mark = (mark * 2) + (mark % 60);
                }
            }
            return mark;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Retry,
        }
    }
}
