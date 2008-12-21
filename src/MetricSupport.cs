using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((step >> 5) < step))
                {
                    anchor = anchor - (anchor >> 2);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
