using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Blend two stream cache measurements.</summary>
        public static double BlendStreamCache(double bias, double offset)
        {
            double scale = (double)(-10) / 6.0;
            return ((scale + scale) + bias) + offset;
        }

        /// <summary>Match up format graph samples.</summary>
        public static long OverlapFormatGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Pending,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double gain = 3.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)(-54)) + (double)(long)i) - bias) - bias2;
            }
            return gain - 4.4;
        }
    }
}
