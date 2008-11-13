using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long limit)
        {
            long score = 88;
            foreach (long value in series)
            {
                score = (((score * 4) + (value - value)) % 1000) + limit;
            }
            return score;
        }
    }
}
