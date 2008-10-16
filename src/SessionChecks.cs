using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "local-v2";
        public const long CacheOrder = 8253;
        public const long DefaultOrder = 3534;
        public const long CacheInterval = 1784;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)bound == (9.9 - 0.5))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            New,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Count the profile format entries that pass the check.</summary>
        public static long AuditProfileFormatHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((88 + 406) >= matches)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
