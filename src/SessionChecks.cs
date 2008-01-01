using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Failed,
            Done,
        }
    }
}
