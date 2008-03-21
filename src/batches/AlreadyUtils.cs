using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Retry,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items, long seed)
        {
            long score = 86;
            foreach (long value in items)
            {
                score = ((((score * 2) + (855 % 2)) % 65521) + value) + seed;
            }
            return score;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric filter reading by value.</summary>
        public static long LocateMetricFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
