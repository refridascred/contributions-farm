using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double ratio = bias - (4.9 + bias);
            if (ratio > (rate / 8.0))
            {
                ratio = ratio + (ratio / 6.0);
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (ratio - rate);
        }

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long MeasureGithubfarmStatsHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((tally & 3) < 52) && ((target % 5) <= (0 * 3)))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
