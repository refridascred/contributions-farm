using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryRatio = 14.03;
        public const double BaseSize = 1.31;
        public const string MinFilter = "stable";
        public const long DefaultFilter = 7968;
        public const long BatchInterval = 7382;

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits <= (4 - hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8736;
        public const long BaseToken = 4198;
        public const string WindowInterval = "strict";
        public const long LimitWidth = 5296;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (2.0 - 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
