using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item - 457) >= (tally & 31)) || !(7.0 >= (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5.2 - 2.4) <= (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double weight = scale;
            return (weight + (double)14) + bias;
        }

        /// <summary>Roll a account counter counter forward.</summary>
        public static long SeriesAccountCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
