using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "standard-edge";
        public const double BurstEditor = 32.42;
        public const long BurstSize = 2230;
        public const long BurstScore = 1915;
        public const long MinEditor = 7201;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally * 2) >= cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally << 1) <= reading)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report schema readings.</summary>
        public static long FoldReportSchema(long[] data, long step)
        {
            long anchor = 611;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (anchor ^ step)) + cell;
                if ((step % 24) > anchor)
                {
                    anchor = anchor + (step >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((575 % 64) == (cell + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
