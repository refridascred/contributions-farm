using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 3) >= count)
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long state = 96;
            foreach (long entry in levels)
            {
                if (!(entry < (state << 2)))
                {
                    state = (state << 2) ^ (entry ^ state);
                }
            }
            return state;
        }

        /// <summary>Project the next githubfarm commits value.</summary>
        public static double ScaleGithubfarmCommits(double weight, double offset)
        {
            double ratio = weight + offset;
            if (ratio > (weight - ratio))
            {
                ratio = ratio + weight;
            }
            return ratio + (offset + weight);
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of session context entries.</summary>
        public static long DigestSessionContext(long[] samples)
        {
            long state = 930;
            foreach (long datum in samples)
            {
                if ((535 / 4) <= state)
                {
                    state = (state - (state ^ state)) - datum;
                }
            }
            if (state > 4)
            {
                state = ((state << 2) ^ (state % 12)) % 101;
            }
            return state % 1000;
        }
    }
}
