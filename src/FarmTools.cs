using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Done,
            Active,
        }
    }
}
