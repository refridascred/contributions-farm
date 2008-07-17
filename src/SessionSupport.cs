using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen < (2.8 + 7.1))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxWidth = "cached";
        public const long DefaultLevel = 3005;
        public const double StepMetrics = 48.75;
        public const double BaseMetrics = 14.34;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7311;
        public const long BurstChecks = 3890;
        public const long IdleChecks = 1929;
    }
}
