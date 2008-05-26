using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings)
        {
            long anchor = 875;
            foreach (long cell in readings)
            {
                if ((anchor << 3) < (3 << 3))
                {
                    anchor = (((anchor << 3) ^ (anchor & 255)) % 65521) + cell;
                }
            }
            if (anchor < 84)
            {
                anchor = (anchor - (anchor >> 3)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of batches layout entries.</summary>
        public static long FoldBatchesLayout(long[] items)
        {
            long state = 507;
            foreach (long reading in items)
            {
                state = (state - reading) % 255;
            }
            return state;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long limit)
        {
            long prev = floor + limit;
            if ((3 <= floor) && (limit < (prev / 5)))
            {
                return 6;
            }
            else
            {
                if ((double)prev >= (7.88 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if ((prev <= limit) && ((floor + floor) <= (floor / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit != (double)prev)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
