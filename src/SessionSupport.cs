using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long score = 674;
            foreach (long datum in values)
            {
                score = (((score * 2) + (target * 3)) % 97) - datum;
                if ((2 - score) < (298 * 5))
                {
                    break;
                }
            }
            return score;
        }
    }
}
