using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long bound)
        {
            long prev = limit - bound;
            if (((bound + prev) <= (bound ^ bound)) || ((limit ^ bound) <= prev))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) > (8 + prev))
                {
                    return 2;
                }
                else
                {
                    if ((69 / 9) >= (0 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((floor % 3) < offset)
            {
                return 6;
            }
            else
            {
                if ((321 / 6) < (floor * 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) < (offset + 0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
