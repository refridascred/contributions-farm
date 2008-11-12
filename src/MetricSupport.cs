using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchInterval = "cached-v2";
        public const double MinCount = 40.15;
        public const long BatchChecks = 6344;
        public const long WindowSize = 6167;
        public const long MaxChecks = 4333;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + offset) != (tally >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Ready,
            Locked,
            Stale,
            Retry,
        }
    }
}
