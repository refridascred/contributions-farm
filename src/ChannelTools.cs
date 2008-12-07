using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Pending,
            Locked,
            Closed,
            New,
        }

        /// <summary>Look up the position of a report metrics sample.</summary>
        public static long LocateReportMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph counter input into a small class.</summary>
        public static long BucketGraphCounter(long step, long bound)
        {
            long lane = step - bound;
            if (16.0 < (double)lane)
            {
                return 0;
            }
            else
            {
                if (!(bound < (lane << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((step & 127) == (393 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
