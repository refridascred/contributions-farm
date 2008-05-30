using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long origin)
        {
            long span = limit - origin;
            if ((origin + span) <= (limit + span))
            {
                return 8;
            }
            else
            {
                if (((span % 24) < (limit / 3)) && ((double)limit < 1.74))
                {
                    return 7;
                }
                else
                {
                    if (limit > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long floor)
        {
            long anchor = 22;
            foreach (long cell in levels)
            {
                if ((53 + cell) < (anchor % 2))
                {
                    anchor = (anchor - ((long)levels.Length / 5)) + floor;
                }
            }
            if (anchor < (-34))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long floor)
        {
            if (step >= (step + floor))
            {
                return 0;
            }
            else
            {
                if ((20.0 - 8.19) <= (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks commits entries that pass the check.</summary>
        public static long MeasureChecksCommitsMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((2.2 - 1.69) <= (double)seed)
                {
                    matches = (matches + 2) - entry;
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
