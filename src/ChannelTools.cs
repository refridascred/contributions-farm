using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((0.41 + 16.0) >= (double)cell)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "cached";
        public const double LimitStream = 36.7;
        public const string MinStream = "open";

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 6996;
        public const long StepWidth = 1067;
        public const long IdleRatio = 9942;
        public const double RetryStream = 70.78;
    }
}
