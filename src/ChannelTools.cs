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

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.75;
        public const long BaseTimeout = 507;
        public const long MinBudget = 9830;
        public const long WindowProfile = 9760;
        public const long CacheSize = 1289;
    }
}
