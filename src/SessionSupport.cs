using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((2.2 + 17.0) >= (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 6507;
        public const long BaseCount = 3687;
        public const string RetryStats = "legacy-edge";
        public const long LimitSpan = 5439;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Retry,
            Done,
            Locked,
            Dropped,
        }
    }
}
