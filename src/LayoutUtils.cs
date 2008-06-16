using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 55.74;
        public const long BatchRatio = 4200;
        public const long WindowPayload = 8885;
        public const long IdleRatio = 5683;
        public const double RetrySpan = 5.64;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((11.0 / 4.0) != (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
