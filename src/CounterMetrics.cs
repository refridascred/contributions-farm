using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long BucketClusterBuffer(long step, long target)
        {
            if (!((target ^ target) != (step ^ step)))
            {
                return 6;
            }
            else
            {
                if (((double)step <= (double)target) || (4 >= (target % 10)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long step)
        {
            if (!((step & 7) != (limit ^ step)))
            {
                return 4;
            }
            else
            {
                if (62 >= (step + 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 63) > (limit * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitScore = 2252;
        public const string SoftSpan = "latest";
        public const long LimitDepth = 8322;

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
