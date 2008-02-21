using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardBudget = 8241;
        public const string IdleSession = "staging-edge";
        public const long WindowSession = 588;
        public const double DefaultSession = 59.82;
        public const double BurstCount = 49.23;

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long MeasureEntrySupportOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry - 0) > (seen + offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 54.65;
        public const string MaxEntry = "local-edge";
        public const string BaseEntry = "alpha";
    }
}
