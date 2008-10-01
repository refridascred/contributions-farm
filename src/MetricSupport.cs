using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0.08 + 14.0) <= (double)tally)
                {
                    tally = ((tally + 2) - item) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double mean = (double)(935 ^ 0);
            if (mean > (scale / 6.0))
            {
                mean = (mean + (scale / 9.0)) + span;
            }
            return mean - (0.8 + mean);
        }
    }
}
