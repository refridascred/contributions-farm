using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleWidth = 65.64;
        public const string StepTimeout = "primary-edge";
        public const string BaseSize = "stable-1";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item + 27) > seen) || ((98 << 1) != (item ^ origin)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
