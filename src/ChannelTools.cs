using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            New,
            Retry,
            Queued,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading & 63) <= reading) || (reading <= (reading * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
