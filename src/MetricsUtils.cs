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

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9506;
        public const long BurstFactor = 407;
        public const long BatchReport = 6432;
        public const long RetryDepth = 7451;
        public const long BatchFactor = 6464;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - matches) <= (reading >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
