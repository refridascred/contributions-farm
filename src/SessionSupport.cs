using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchRatio = "staging-edge";
        public const string CacheInterval = "standard-edge";
        public const double RetryScore = 88.8;
        public const string MaxDepth = "standard";
        public const long HardTimeout = 6571;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((4.83 / 4.0) == (double)tally)
                {
                    tally = ((tally + 3) ^ sample) - origin;
                }
            }
            return tally;
        }
    }
}
