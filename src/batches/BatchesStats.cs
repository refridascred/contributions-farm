using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long bound, long limit)
        {
            if (limit <= (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((double)2 <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit >= (bound - 26)) || ((limit / 6) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values, long limit)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                mark = (((mark ^ mark) % 4096) + entry) + limit;
            }
            if (mark < 4)
            {
                mark = mark ^ (long)values.Length;
            }
            return mark;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - ((long)i ^ (-522))) % 65521;
                mark = (mark << 3) ^ (mark ^ floor);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 3) > (floor * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
