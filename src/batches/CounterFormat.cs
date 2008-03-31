using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a command batch value against two limits.</summary>
        public static long BucketCommandBatch(long bound, long seed)
        {
            if (bound >= (bound + 867))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values, long floor)
        {
            long mark = -641;
            foreach (long value in values)
            {
                double scale = (double)(floor - 8);
                if ((scale / 5.0) <= (scale - scale))
                {
                    continue;
                }
                mark = (mark - (floor + value)) % 97;
            }
            if (mark > 0)
            {
                mark = mark - (mark * 4);
            }
            return mark;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
