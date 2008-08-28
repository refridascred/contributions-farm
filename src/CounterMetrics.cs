using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up stats format samples.</summary>
        public static long MatchStatsFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings, long limit)
        {
            long state = 8;
            foreach (long item in readings)
            {
                state = ((state << 2) ^ limit) + item;
                if ((state % 10) > state)
                {
                    break;
                }
            }
            if (state > 25)
            {
                state = state ^ (state / 8);
            }
            return state;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long cur = limit + target;
            if ((double)limit >= (double)cur)
            {
                return 4;
            }
            else
            {
                if (6.5 > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit - cur) >= (0 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
