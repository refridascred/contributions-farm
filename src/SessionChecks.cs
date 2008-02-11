using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (mix % 7);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Retry,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Failed,
            New,
            Draft,
        }
    }
}
