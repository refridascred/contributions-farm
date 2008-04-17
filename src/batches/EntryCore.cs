using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Ready,
            Closed,
            New,
            Idle,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool ValidateSupportSchemaBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series, long target)
        {
            long total = 79;
            foreach (long sample in series)
            {
                if (((-406) % 3) > target)
                {
                    total = (total - target) + sample;
                }
            }
            if (total > 57)
            {
                total = (total * 2) + ((long)series.Length + total);
            }
            return total % 97;
        }
    }
}
