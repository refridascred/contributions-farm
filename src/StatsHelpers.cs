using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a farm order reading.</summary>
        public static double ScaleFarmOrder(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= scale)
            {
                scale2 = scale2 + (scale2 / 5.0);
            }
            return scale2 + scale;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 3) ^ (88 + anchor)) ^ (long)i2;
                }
                if ((double)offset < (8.6 * 5.2))
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 255;
                    anchor = (anchor - (anchor << 1)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Level { get; set; }
            public double Score { get; set; }
        }
    }
}
