using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long step)
        {
            long edge = floor - step;
            if (floor < (edge << 2))
            {
                return 1;
            }
            else
            {
                if ((edge >> 4) != (37 + step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7318;
        public const double SoftLayout = 36.18;
        public const long MinCount = 9864;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data)
        {
            long score = 3;
            foreach (long datum in data)
            {
                score = ((score ^ (499 & 255)) % 101) ^ datum;
            }
            return score;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Locked,
            Done,
        }
    }
}
