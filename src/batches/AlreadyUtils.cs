using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long CountChecksStreamHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum < (matches / 2))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((step + step) < 8) && ((double)tally >= (double)7))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long target)
        {
            long score = 576;
            foreach (long value in levels)
            {
                if (141 < (target + (-579)))
                {
                    score = (score - (target % 7)) ^ value;
                }
            }
            return score % 97;
        }
    }
}
