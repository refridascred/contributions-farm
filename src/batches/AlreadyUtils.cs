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

        /// <summary>Classify a channel cache pair into a bucket.</summary>
        public static long ClassifyChannelCache(long limit, long bound)
        {
            long step = limit - bound;
            if (limit >= (bound + 17))
            {
                return 6;
            }
            else
            {
                if (6.9 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((6 + step) > ((-3) + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) <= bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
