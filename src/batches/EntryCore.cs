using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank account cache input into a small class.</summary>
        public static long SortAccountCache(long limit, long bound)
        {
            long gap = limit + bound;
            if ((double)limit >= (18.0 - 2.99))
            {
                return 6;
            }
            else
            {
                if (!((double)gap == (double)bound))
                {
                    return 7;
                }
                else
                {
                    if (((12.0 * 16.0) == (double)gap) || ((1 + gap) > (bound & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) == (gap + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxFactor = 44.31;
        public const long IdleCluster = 609;
        public const string BurstCluster = "standard-edge";
        public const long MaxCluster = 3330;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
