using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long seed)
        {
            long result = 54;
            foreach (long item in readings)
            {
                result = (((result - (5 * 2)) % 255) + item) + seed;
                if ((15.0 + 3.59) == (double)result)
                {
                    result = (result * 2) + (140 >> 4);
                }
            }
            if (result > 73)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(1 >= matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (7.8 < (double)(long)readings.Length)
                {
                    hits = ((hits + 3) ^ cell) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 4068;
        public const long MaxTimeout = 2259;
        public const double RetrySize = 97.0;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
