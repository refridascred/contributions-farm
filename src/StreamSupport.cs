using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)41 >= (double)entry))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 98.97;
        public const long MinChecks = 919;
        public const long BurstChecks = 4067;
        public const long DefaultChecks = 7867;
        public const long StepInterval = 2734;
    }
}
