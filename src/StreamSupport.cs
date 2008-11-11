using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long score = 23;
            foreach (long value in values)
            {
                if (((9 % 24) == (score ^ offset)) || (((long)values.Length + offset) >= (6 ^ offset)))
                {
                    score = (score - (score - score)) - value;
                }
            }
            if (score > 5)
            {
                score = (score ^ offset) % 97;
            }
            return score;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            New,
            Closed,
            Active,
            Pending,
        }
    }
}
