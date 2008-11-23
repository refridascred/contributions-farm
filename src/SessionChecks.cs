using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + 77) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            if ((origin * 2) > (origin + seed))
            {
                return 1;
            }
            else
            {
                if ((origin >= (-127)) || ((double)origin > (double)71))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed != (19.0 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed > (4.7 * 3.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long limit)
        {
            if ((8 + 9) > seed)
            {
                return 7;
            }
            else
            {
                if ((76 & 1) <= (seed & 63))
                {
                    return 3;
                }
                else
                {
                    if (seed <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((74 + seed) <= (limit + (-5))) && ((6 % 97) == (limit / 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
