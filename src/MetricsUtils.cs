using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long limit)
        {
            if (!((floor << 2) <= (floor & 31)))
            {
                return 4;
            }
            else
            {
                if ((double)24 >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit * 2) <= (8 + 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
