using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!!(9 >= seen))
                {
                    seen = ((seen + 3) - datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultScore = 4726;
        public const long BaseWindow = 7894;
        public const double RetryWindow = 53.32;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchTimeout = 718;
        public const long DefaultWindow = 2515;
        public const long WindowCount = 8654;
        public const long MinDepth = 7802;
    }
}
