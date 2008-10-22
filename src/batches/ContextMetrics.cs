using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long TallyFilterQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!!(10.0 <= (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Done,
            Dropped,
            Ready,
            Paused,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
