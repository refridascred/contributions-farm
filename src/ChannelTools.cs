using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((5 / 7) > (origin >> 3))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Dropped,
            Paused,
            Pending,
        }
    }
}
