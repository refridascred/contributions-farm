using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if (2.9 <= (double)state)
                {
                    continue;
                }
                if (((long)i + state) > 3)
                {
                    state = ((state << 3) ^ (step - step)) % 97;
                    state = (state ^ (state + state)) % 97;
                }
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every channel cluster entry stays within the limit.</summary>
        public static bool GuardChannelClusterLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (740 >= cur)
            {
                return 0;
            }
            else
            {
                if ((13.0 - 1.76) <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + 52) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
