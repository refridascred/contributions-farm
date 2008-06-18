using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheLevel = 1145;
        public const long RetryTimeout = 1118;
        public const string IdleFactor = "local-edge";

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((offset + 85) == (518 + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 2551;
        public const double MaxRatio = 48.37;
        public const long StepEntry = 8154;
        public const long BaseDepth = 638;
    }
}
