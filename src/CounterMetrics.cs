using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 3426;
        public const long DefaultReport = 6126;
        public const long BatchWidth = 9635;

        /// <summary>Roll a commits token counter forward.</summary>
        public static long StepCommitsToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 2) + (316 - 54);
                total = total - origin;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next metrics profile value from a seed.</summary>
        public static long RollMetricsProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2923;
        public const long MinChecks = 3818;
        public const long LimitSpan = 4047;
        public const long BatchSpan = 5312;
        public const long BaseChecks = 7097;
    }
}
