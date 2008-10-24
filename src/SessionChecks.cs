using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool VerifyFormatFarmLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitDepth = 58.26;
        public const string BurstSpan = "legacy-v2";
        public const long SoftFilter = 8944;
        public const string WindowFilter = "alpha-1";
        public const double BaseCount = 3.78;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 4103;
        public const string RetryContributi = "staging-v2";
        public const string DefaultContributi = "local-v2";
        public const double BatchInterval = 47.97;
    }
}
