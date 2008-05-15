using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit channel stats readings against a rule.</summary>
        public static long MeasureChannelStatsOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading < (floor >> 4))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((double)hits <= (double)0))
                {
                    hits = ((hits + 2) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long total = 188;
            foreach (long reading in levels)
            {
                if ((double)reading > (8.1 - 8.45))
                {
                    total = total + floor;
                }
            }
            return total;
        }
    }
}
