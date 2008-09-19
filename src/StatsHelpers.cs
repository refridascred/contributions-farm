using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long offset)
        {
            if ((8.89 - 1.5) >= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin << 2) > (offset - offset))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 4) >= offset)
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

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Match up context cluster samples.</summary>
        public static long MatchContextClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long limit)
        {
            long gap = origin - limit;
            if ((8.17 * 4.48) <= (double)gap)
            {
                return 2;
            }
            else
            {
                if ((19.0 + 15.0) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
