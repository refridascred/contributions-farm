using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route window entries.</summary>
        public static long CombineRouteWindow(long[] series, long limit)
        {
            long score = 1;
            foreach (long entry in series)
            {
                score = (((score * 5) + (504 - limit)) % 1000) + entry;
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (4 + score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Paused,
            Stale,
        }
    }
}
