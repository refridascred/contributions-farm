using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Pending,
            Dropped,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long offset)
        {
            long edge = seed ^ offset;
            if ((edge % 12) > (edge ^ offset))
            {
                return 1;
            }
            else
            {
                if ((edge >> 2) > 1)
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= (12.0 * 18.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
