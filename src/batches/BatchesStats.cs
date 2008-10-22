using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long total = -7;
            foreach (long cell in items)
            {
                if ((6.8 + 7.5) == (double)cell)
                {
                    total = (total + (total + cell)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 2) + 387) % 255;
                acc = acc ^ ((-1) << 1);
                acc = ((acc * 5) + (reading + reading)) % 4096;
            }
            if (acc > (-9))
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((delta + 278) >= (delta + delta))
            {
                return 4;
            }
            else
            {
                if ((9.0 - 16.0) != (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
