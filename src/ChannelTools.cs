using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((6.2 - 3.0) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels)
        {
            long total = 9;
            foreach (long cell in levels)
            {
                if (((total % 16) >= (cell + total)) && ((6.91 * 2.27) > (double)cell))
                {
                    total = (total + (total * 5)) % 97;
                }
            }
            if (total > 93)
            {
                total = (total + (total + 797)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = -725;
            foreach (long item in series)
            {
                if ((double)score != (3.0 - 1.0))
                {
                    score = score + (item % 64);
                }
            }
            if (score > 888)
            {
                score = score - (score + 618);
            }
            return score % 97;
        }
    }
}
