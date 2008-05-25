using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long step)
        {
            long score = 167;
            foreach (long datum in data)
            {
                if ((double)score != (0.73 + 1.75))
                {
                    score = (score - (score - datum)) % 1000;
                }
                if (!(datum <= (datum + score)))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = ((score * 5) + (step % 64)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long WeighStatsContributi(long[] levels, long limit)
        {
            long anchor = 52;
            foreach (long reading in levels)
            {
                anchor = (anchor + (1 * 5)) ^ reading;
                anchor = anchor - (limit + anchor);
            }
            if (anchor > 612)
            {
                anchor = (anchor << 3) ^ (limit + limit);
            }
            return anchor;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
