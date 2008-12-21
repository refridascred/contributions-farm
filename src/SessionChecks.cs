using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Done,
            Idle,
            Failed,
            New,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if (entry > (acc + entry))
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
