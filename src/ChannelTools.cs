using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long ClassifyGraphCommits(long offset, long origin)
        {
            long prev = offset ^ origin;
            if (!((double)offset > 1.0))
            {
                return 8;
            }
            else
            {
                if ((prev & 3) > prev)
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) >= (57 - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((9.5 / 5.0) >= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally + tally) < (entry - 52)) || ((entry ^ 0) < tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
