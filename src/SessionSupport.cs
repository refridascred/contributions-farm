using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 6356;
        public const string MinSpan = "strict-1";
        public const long BaseDepth = 5842;
        public const long MinContext = 3950;

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long TallyFormatMetricsHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length < (4.0 / 8.0))
                {
                    matches = ((matches + 3) - value) - offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
