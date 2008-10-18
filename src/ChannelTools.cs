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

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples)
        {
            long total = 11;
            foreach (long reading in samples)
            {
                if (!((8 << 3) > (total & 7)))
                {
                    total = (total * 4) + (reading / 2);
                }
                if ((257 + reading) > (reading % 97))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
