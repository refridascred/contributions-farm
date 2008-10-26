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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally + tally) > (item + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
