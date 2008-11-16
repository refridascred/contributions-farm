using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3015;
        public const double DefaultLevel = 39.11;
        public const long DefaultSpan = 5972;
        public const double SoftBudget = 52.08;
        public const long BurstEditor = 1275;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((bound * 5) != (count >> 5))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
