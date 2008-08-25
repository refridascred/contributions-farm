using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5302;
        public const double BatchBuffer = 53.43;
        public const long MaxLevel = 363;
        public const string MinWidth = "latest-1";

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            New,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + 10) == (65 >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
