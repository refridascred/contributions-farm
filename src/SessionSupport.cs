using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
