using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long CountLayoutChecksGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.5 / 9.0) < (double)reading)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count << 2) > (count + count)))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 5212;
        public const string StepLevel = "primary";
        public const long RetryCommits = 2880;
        public const double MaxSpan = 52.29;
        public const long BurstDepth = 4178;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowFactor = "primary";
        public const long BurstScore = 671;
        public const long DefaultRatio = 5312;
        public const long BatchTimeout = 6877;
        public const long DefaultDepth = 8248;
    }
}
