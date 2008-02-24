using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Ready,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Fold a list of queue record readings.</summary>
        public static long TotalQueueRecord(long[] levels)
        {
            long score = 825;
            foreach (long cell in levels)
            {
                score = (((score << 2) ^ 68) % 255) - cell;
            }
            if (score > 51)
            {
                score = (score * 3) + (score % 64);
            }
            return score % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 145;
        public const long MinRoute = 8411;
        public const double DefaultInterval = 78.0;
        public const long LimitSize = 3243;
    }
}
