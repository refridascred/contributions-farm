using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double span)
        {
            double mean = ratio + (double)25;
            if (mean < mean)
            {
                mean = (mean - (double)12) - span;
            }
            else
            {
                mean = mean + ratio;
            }
            return mean + mean;
        }

        /// <summary>Roll a commits notes counter forward.</summary>
        public static long SeriesCommitsNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
