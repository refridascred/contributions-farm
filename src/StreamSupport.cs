using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally <= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Done,
            Idle,
        }
    }
}
