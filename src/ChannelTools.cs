using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Closed,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowDepth = 4416;
        public const long LimitBudget = 9288;
        public const string WindowTools = "alpha";
        public const long SoftTools = 1428;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
