using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Validate token checks readings against a bound.</summary>
        public static bool CheckTokenChecksBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
