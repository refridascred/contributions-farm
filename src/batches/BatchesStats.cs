using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream notes counter forward.</summary>
        public static long SeriesStreamNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit session githubfarm readings against a rule.</summary>
        public static long CountSessionGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((2.0 - 9.1) == (double)reading) || ((6.6 + 6.77) < (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((7.64 / 3.0) <= (double)hits)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks commits series from a seed.</summary>
        public static long DeriveChecksCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
