using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token session readings.</summary>
        public static long MatchTokenSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long floor, long limit)
        {
            long step = floor - limit;
            if (limit > (limit + limit))
            {
                return 2;
            }
            else
            {
                if ((step + floor) >= (limit - step))
                {
                    return 6;
                }
                else
                {
                    if ((16.0 / 9.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (6.0 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long floor)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = ((acc - (value ^ value)) % 101) - floor;
            }
            if (acc < (-980))
            {
                acc = (acc * 5) + (acc >> 1);
            }
            return acc;
        }
    }
}
