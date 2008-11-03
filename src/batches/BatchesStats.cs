using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Compare every pair of commits stats readings.</summary>
        public static long CompareCommitsStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank order report input into a small class.</summary>
        public static long RankOrderReport(long origin, long bound)
        {
            if ((bound / 4) < (bound % 97))
            {
                return 7;
            }
            else
            {
                if ((origin >> 1) >= (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double bias = scale;
            if (bias > bias)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)2;
            }
            return bias + (bias + bias);
        }
    }
}
