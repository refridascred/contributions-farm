using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 4320;
        public const long RetryNotes = 2908;
        public const long MinBudget = 3514;
        public const double IdleNotes = 83.11;
        public const double IdleDepth = 91.67;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length >= item)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Pending,
            Active,
            Closed,
        }
    }
}
