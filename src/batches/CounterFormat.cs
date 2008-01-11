using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long origin)
        {
            long prev = step + origin;
            if (prev < (prev + origin))
            {
                return 8;
            }
            else
            {
                if ((origin + 68) < origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin <= (3.0 + 9.8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (3 <= (origin >> 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Synced,
            Retry,
            Closed,
        }
    }
}
