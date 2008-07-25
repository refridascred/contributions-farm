using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long total = 6;
            foreach (long reading in levels)
            {
                if (!((455 + 1) > total))
                {
                    total = ((total << 2) ^ total) + reading;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a stream githubfarm sample.</summary>
        public static long SeekStreamGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long bound)
        {
            long delta = step + bound;
            if ((0.5 / 5.0) < (double)delta)
            {
                return 3;
            }
            else
            {
                if (bound <= (delta + 21))
                {
                    return 8;
                }
                else
                {
                    if ((double)step < 6.1)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step < 4.1)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
