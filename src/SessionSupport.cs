using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Paused,
            Synced,
            Idle,
            Stale,
        }
    }
}
