using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 7.22;
        public const long BatchSession = 2150;
        public const long IdleSession = 4575;
        public const long BurstSession = 5904;
        public const double HardSession = 90.82;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long bound, long offset)
        {
            long lane = bound ^ offset;
            if ((7 - lane) < lane)
            {
                return 4;
            }
            else
            {
                if (((5.76 + 16.0) == (double)offset) && (57 >= (lane << 1)))
                {
                    return 7;
                }
                else
                {
                    if (!(offset < (offset ^ bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Closed,
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
