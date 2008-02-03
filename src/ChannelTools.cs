using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report notes samples are out of range.</summary>
        public static long AuditReportNotesGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((4.12 <= (double)sample) || ((double)sample == (7.0 + 2.85))) || (((5.0 * 7.0) <= (double)sample) || ((sample / 7) >= (sample - seen))))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryDepth = 874;
        public const long BaseContributi = 3382;
        public const string LimitLevel = "strict-1";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value < 2.14)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
