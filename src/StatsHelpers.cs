using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if (((272 + anchor) > (anchor >> 1)) && (anchor >= (anchor * 5)))
                {
                    anchor = ((anchor << 3) ^ (518 * 3)) % 65521;
                }
                if ((limit + datum) >= 310)
                {
                    anchor = (anchor * 2) + datum;
                }
            }
            if (anchor > 89)
            {
                anchor = anchor ^ limit;
            }
            return anchor % 65521;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up context cluster samples.</summary>
        public static long MatchContextClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                long bound = (state + 69) >> 3;
                if (!((bound - (long)i) <= 250))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long limit)
        {
            if ((limit >> 3) > 9)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) <= target)
                {
                    return 6;
                }
                else
                {
                    if ((target + target) < (446 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((442 - target) >= (target & 7))
                        {
                            return 3;
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
