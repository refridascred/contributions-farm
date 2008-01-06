using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long step)
        {
            long score = 2;
            foreach (long item in levels)
            {
                score = (((score << 2) ^ (step + score)) % 4096) - item;
                if (((4 - step) >= step) && (score <= (step << 1)))
                {
                    break;
                }
            }
            if (score < 93)
            {
                score = (score - score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long step)
        {
            if ((step / 9) < (step + step))
            {
                return 7;
            }
            else
            {
                if (!((step + 44) > (step / 5)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Done,
            Idle,
        }
    }
}
