using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long TallyStreamSchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((12.0 - 13.0) <= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 75.34;
        public const long BaseScore = 1456;
        public const string WindowSize = "alpha-edge";
        public const double CacheWindow = 27.67;
        public const string HardRatio = "stable";
    }
}
