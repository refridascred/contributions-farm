using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(count <= (entry % 12)) || (entry < ((-73) ^ entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((state & 15) > ((long)i >> 4))
                {
                    state = state ^ (origin / 8);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long ScoreReportCommits(long[] values)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if ((636 >> 2) == (acc - 4))
                {
                    acc = (acc - (item << 1)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count githubfarm tools pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepCount = 1595;
        public const long MinStream = 2564;
        public const long IdleScore = 6697;
    }
}
