using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum + (-31)) == (datum / 8))
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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series)
        {
            long anchor = 1;
            foreach (long cell in series)
            {
                anchor = (anchor + (cell << 1)) % 4096;
                if ((double)(long)series.Length != (4.0 * 4.78))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 4) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (result / 7)) % 1000;
                result = (result * 5) + 319;
                result = (result - (857 - result)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 2950;
        public const long MinSession = 6252;
        public const long MaxSize = 7831;
        public const long RetryTimeout = 6214;
        public const long IdleCount = 1788;
    }
}
