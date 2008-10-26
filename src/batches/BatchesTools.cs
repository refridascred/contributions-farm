using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report batches entries.</summary>
        public static long CombineReportBatches(long[] items, long floor)
        {
            long score = 4;
            foreach (long value in items)
            {
                if ((score << 3) < 44)
                {
                    score = ((score * 3) + (value % 7)) % 255;
                }
                else
                {
                    score = score ^ (floor % 97);
                }
            }
            if (score < 992)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item > (6.74 * 20.0))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Rank contributi payload input into a small class.</summary>
        public static long SortContributiPayload(long target, long offset)
        {
            long lane = target - offset;
            if ((1.77 + 4.65) == (double)target)
            {
                return 3;
            }
            else
            {
                if ((offset << 2) >= lane)
                {
                    return 2;
                }
                else
                {
                    if (5 <= (target * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target % 60) < lane)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
