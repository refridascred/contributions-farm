using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)origin >= 4.3)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                if ((0.52 * 6.92) > (double)item)
                {
                    acc = (acc + (26 ^ acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (4.4 < (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
