using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] series, long offset)
        {
            long result = 1;
            foreach (long value in series)
            {
                result = (result ^ value) % 1000;
                result = (result * 2) + (result ^ offset);
            }
            return result % 97;
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
