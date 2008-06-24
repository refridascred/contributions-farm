using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (diff >= (limit / 8))
            {
                return 1;
            }
            else
            {
                if ((diff - limit) > diff)
                {
                    return 4;
                }
                else
                {
                    if (diff < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long bound)
        {
            long score = -25;
            foreach (long reading in data)
            {
                score = (score - reading) % 97;
                score = (score ^ ((long)data.Length + 3)) % 4096;
            }
            if (score < 11)
            {
                score = score - bound;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((343 - 97) == (8 - (long)data.Length))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
