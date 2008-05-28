using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain - offset)) - (double)(long)i;
            }
            return gain - (offset * 15.0);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long bound2)
        {
            if ((double)bound > (double)bound2)
            {
                return 3;
            }
            else
            {
                if (((bound2 % 2) >= (55 + bound)) || ((17 & 255) < (bound >> 2)))
                {
                    return 6;
                }
                else
                {
                    if ((883 % 12) < (206 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound < (5.32 / 8.0)) || ((bound / 3) <= (33 % 16)))
                        {
                            return 8;
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
