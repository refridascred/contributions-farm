using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
