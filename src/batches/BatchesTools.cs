using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double weight = rate;
            return weight + span;
        }

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((-27) >= (target - target))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!!(origin < ((long)i & 3)))
                {
                    total = ((total * 2) + total) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
