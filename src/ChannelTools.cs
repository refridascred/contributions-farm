using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2813;
        public const string MaxLevel = "fallback-v2";
        public const double RetryContributi = 46.12;

        /// <summary>Audit order layout readings against a rule.</summary>
        public static long AuditOrderLayoutHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading % 64) >= (tally ^ 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Stale,
            Synced,
            Idle,
        }
    }
}
