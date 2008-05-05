using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank queue format input into a small class.</summary>
        public static long BucketQueueFormat(long step, long bound)
        {
            long span = step - bound;
            if ((step + step) == (span << 3))
            {
                return 5;
            }
            else
            {
                if (8.2 > (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((bound - 16) <= (step + 9)) && (70 < (span / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long floor)
        {
            long anchor = 68;
            foreach (long entry in values)
            {
                anchor = (anchor ^ entry) % 101;
                if (((entry - 89) > floor) && (floor >= (4 * 2)))
                {
                    anchor = anchor + (18 - floor);
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor + floor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.8 - 6.42) != (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a cluster queue reading by value.</summary>
        public static long SeekClusterQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Ready,
            Queued,
            Paused,
            New,
        }
    }
}
