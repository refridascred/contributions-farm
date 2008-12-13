using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.4;
        public const double StepToken = 30.6;
        public const long BatchCount = 7827;
        public const long BurstToken = 6067;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 90.82;
        public const double SoftTools = 91.94;
        public const double LimitTools = 6.42;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((seen % 60) > seen) || ((1.0 + 7.67) >= (double)sample)) && ((seen % 97) > (sample >> 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
