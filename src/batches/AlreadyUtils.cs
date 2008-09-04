using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many layout tools samples are out of range.</summary>
        public static long AuditLayoutToolsOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((4 >> 4) == (reading + (-8)))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double drift = span;
            if (drift > gain)
            {
                drift = drift + (drift * 9.6);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (gain * 19.0);
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Active,
            Paused,
            Queued,
            Synced,
        }
    }
}
