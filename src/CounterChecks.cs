using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally <= 3.0)
                {
                    tally = ((tally + 1) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph already samples are out of range.</summary>
        public static long MeasureGraphAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (2.8 * 2.86))
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

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((double)prev >= 8.9)
            {
                return 6;
            }
            else
            {
                if (((prev << 3) != (3 ^ seed2)) && ((double)prev != (double)seed2))
                {
                    return 4;
                }
                else
                {
                    if (((6 << 1) >= prev) && (seed2 < (70 >> 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev > (seed2 ^ 0)) && ((20.0 - 4.4) == (double)prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i >> 3) < score))
                {
                    score = ((score << 2) ^ (limit / 8)) % 255;
                    score = ((score * 5) + (limit * 3)) % 97;
                    break;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 82.08;
        public const long MaxSize = 1257;
        public const double BatchGithubfarm = 27.69;
        public const double BaseGithubfarm = 27.87;
        public const double BaseRatio = 1.07;
    }
}
