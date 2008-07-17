using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length > (19.0 * 6.25))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double scale = ratio - (ratio + 4.0);
            if (scale >= (ratio * 8.0))
            {
                scale = scale - (scale - bias);
            }
            return scale - (7.0 * 18.0);
        }
    }
}
