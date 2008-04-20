using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Locked,
            Queued,
            Done,
            New,
        }

        /// <summary>Validate format route readings against a bound.</summary>
        public static bool CheckFormatRouteRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
