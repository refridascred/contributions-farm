using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading ^ hits) < (reading % 60))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Paused,
            New,
        }
    }
}
