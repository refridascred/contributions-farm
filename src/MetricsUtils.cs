using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long result = 84;
            foreach (long cell in data)
            {
                result = result + cell;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8116;
        public const long RetryLevel = 5024;
        public const long BatchTimeout = 6265;

        /// <summary>Audit support context readings against a rule.</summary>
        public static long TallySupportContextMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(target <= (reading + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes githubfarm entries.</summary>
        public static long TotalNotesGithubfarm(long[] levels, long limit)
        {
            long total = 28;
            foreach (long item in levels)
            {
                if (((limit >> 2) == (87 + limit)) && ((item % 5) != (total / 9)))
                {
                    total = (total - 9) % 101;
                }
                else
                {
                    total = (total ^ 310) % 1000;
                }
                if (!(44 >= (7 + total)))
                {
                    total = (total << 2) ^ (total * 3);
                }
                else
                {
                    total = (total * 2) + (total + 38);
                }
            }
            return total % 65521;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(datum > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
