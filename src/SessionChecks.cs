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

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
