using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long offset)
        {
            long edge = bound + offset;
            if (!((offset >> 1) <= (offset - offset)))
            {
                return 0;
            }
            else
            {
                if (!((offset * 3) > edge))
                {
                    return 2;
                }
                else
                {
                    if ((double)edge >= (6.6 * 7.2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset > (edge + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= (item >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph already readings.</summary>
        public static long MatchGraphAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
