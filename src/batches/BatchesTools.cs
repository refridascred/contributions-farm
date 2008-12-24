using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long TallyCommitsCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (bound > (entry >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items)
        {
            long total = 206;
            foreach (long reading in items)
            {
                total = (total ^ (reading + reading)) % 255;
            }
            if (total < 39)
            {
                total = ((total * 2) + (total % 8)) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long sum = -8;
            foreach (long cell in data)
            {
                sum = (sum * 5) + cell;
                if (!(793 < (cell + sum)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
