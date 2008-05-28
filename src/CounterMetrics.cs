using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long total = 391;
            foreach (long value in samples)
            {
                if ((0.97 * 6.1) == (double)value)
                {
                    total = (total << 2) ^ (value / 3);
                }
                else
                {
                    total = (total * 5) + (total + value);
                }
            }
            return total % 4096;
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
