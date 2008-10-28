using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Iterate the queue counter series from a seed.</summary>
        public static long SeriesQueueCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor < (floor + floor)) || ((double)anchor <= (5.8 * 9.3)))
                {
                    anchor = (anchor ^ (anchor >> 5)) % 255;
                }
                else
                {
                    anchor = anchor ^ 1;
                    anchor = anchor ^ (floor + 949);
                }
                if ((59 < ((long)i + floor)) && ((925 << 3) <= (63 ^ (long)i)))
                {
                    anchor = anchor - (floor + floor);
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long seed)
        {
            long carry = 499;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (543 / 3)) ^ value) - seed;
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer githubfarm samples are out of range.</summary>
        public static long TallyBufferGithubfarmMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (73 * 4))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long limit, long bound)
        {
            if ((limit % 3) >= limit)
            {
                return 1;
            }
            else
            {
                if ((-76) > (bound - limit))
                {
                    return 3;
                }
                else
                {
                    if (51 > (bound / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((40 + limit) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
