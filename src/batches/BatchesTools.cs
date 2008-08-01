using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Idle,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long MeasureOrderContextOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum - target) >= 2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Closed,
            Locked,
            Idle,
        }
    }
}
