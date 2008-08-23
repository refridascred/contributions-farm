using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSize = 25.97;
        public const long LimitDepth = 7139;
        public const long SoftChecks = 4402;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate cache schema readings against a bound.</summary>
        public static bool ValidateCacheSchemaLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
