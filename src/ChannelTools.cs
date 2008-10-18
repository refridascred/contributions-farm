using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Closed,
            Queued,
            New,
            Idle,
        }

        /// <summary>Fold a list of command channel readings.</summary>
        public static long DigestCommandChannel(long[] samples, long origin)
        {
            long result = 0;
            foreach (long reading in samples)
            {
                result = ((result + origin) % 65521) + reading;
            }
            return result;
        }
    }
}
