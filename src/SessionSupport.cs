using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Locate a cache batches reading by value.</summary>
        public static long FindCacheBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long limit, long bound)
        {
            long next = limit + bound;
            if ((double)next <= (0.21 * 14.0))
            {
                return 6;
            }
            else
            {
                if ((limit + bound) == (bound >> 2))
                {
                    return 1;
                }
                else
                {
                    if (((next >> 4) < (next - limit)) || ((59 * 2) > next))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)next == (10.0 * 1.1))
                        {
                            return 5;
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
