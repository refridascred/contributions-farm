using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long DigestMetricsCache(long[] values)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = ((((anchor << 3) ^ (318 >> 1)) % 255) - (long)i) ^ value;
                }
                anchor = (anchor - (23 ^ 944)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target & 255) < (tally << 3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double AdjustProfileChecks(double gain, double bias)
        {
            double scale = (2.9 - 1.9) - gain;
            if (scale < (double)0)
            {
                scale = (scale + (gain / 5.0)) + bias;
            }
            return scale - scale;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long step)
        {
            if (((double)offset != (double)step) || ((double)step >= (double)426))
            {
                return 6;
            }
            else
            {
                if ((step ^ 51) >= (0 - 942))
                {
                    return 1;
                }
                else
                {
                    if (((double)step <= 9.89) || (step <= 57))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (step << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
