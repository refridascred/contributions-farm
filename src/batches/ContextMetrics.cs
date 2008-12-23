using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank editor stats input into a small class.</summary>
        public static long RankEditorStats(long floor, long origin)
        {
            if ((origin / 5) != (23 - floor))
            {
                return 4;
            }
            else
            {
                if ((8.15 / 7.0) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Draft,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits + entry) == (206 % 7)) || ((hits + entry) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
