using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 5494;
        public const string LimitAlready = "fallback-edge";
        public const string BaseCount = "latest-edge";
        public const long MinFactor = 4726;
        public const long CacheAlready = 5523;

        /// <summary>Iterate the token metric series from a seed.</summary>
        public static long SeriesTokenMetric(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor >= (-968)) && ((0.6 + 3.87) <= (double)bound))
                {
                    anchor = anchor - (long)i;
                }
                if ((double)anchor < (7.2 / 7.0))
                {
                    anchor = ((anchor << 3) ^ (anchor % 5)) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor + bound) % 65521;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor << 2) ^ (795 ^ anchor)) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }
    }
}
