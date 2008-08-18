using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Paused,
            Retry,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
