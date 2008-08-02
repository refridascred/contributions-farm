using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseTimeout = 2955;
        public const long BatchToken = 208;
        public const long DefaultSize = 765;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
