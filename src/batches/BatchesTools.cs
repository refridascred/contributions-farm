using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark - (82 + origin)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank batch metrics input into a small class.</summary>
        public static long ClassifyBatchMetrics(long floor, long offset)
        {
            long gap = floor + offset;
            if (!((31 - offset) <= offset))
            {
                return 6;
            }
            else
            {
                if ((gap << 2) < (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (((gap - gap) < (gap * 2)) && ((offset << 3) != (floor + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of command cluster readings.</summary>
        public static long DigestCommandCluster(long[] data, long origin)
        {
            long sum = 21;
            foreach (long value in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (value << 1)) + (long)i;
                }
                if (((long)data.Length - value) < value)
                {
                    sum = sum ^ (sum + sum);
                }
                sum = (sum - origin) % 101;
            }
            return sum;
        }
    }
}
