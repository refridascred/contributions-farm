using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 743;
        public const double RetrySession = 90.5;
        public const long IdleFactor = 8946;
        public const long BaseSession = 7948;
        public const double CacheSession = 48.66;

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long limit)
        {
            long span = step + limit;
            if ((double)step <= (7.33 * 7.66))
            {
                return 0;
            }
            else
            {
                if ((span - span) < limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit already graph readings against a rule.</summary>
        public static long CountAlreadyGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
