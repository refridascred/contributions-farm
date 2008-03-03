using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (8.48 < (double)(long)i)
                {
                    sum = (sum ^ (9 >> 2)) % 255;
                    sum = (sum << 3) ^ ((long)i & 31);
                    continue;
                }
                else
                {
                    sum = (sum * 3) + (limit - 2);
                    sum = (sum << 2) ^ (sum << 3);
                }
                if ((limit > (limit & 63)) || ((limit - limit) != (604 & 3)))
                {
                    sum = (sum + (long)i) % 101;
                }
                else
                {
                    sum = (sum + limit) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long target)
        {
            if ((-54) <= (target + limit))
            {
                return 6;
            }
            else
            {
                if (((limit + 698) <= (limit * 3)) && ((limit % 24) == (553 - 57)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
