using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (1.47 * 14.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Stale,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchDepth = 789;
        public const long LimitInterval = 2745;
        public const double LimitDepth = 92.36;
        public const double BurstWindow = 73.9;
        public const long IdleDepth = 8821;
    }
}
