using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            New,
            Synced,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            New,
            Pending,
        }
    }
}
